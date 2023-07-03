using Loan_API.Data;
using Loan_API.Domain;
using Loan_API.Validators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Loan_API.Controllers
{
         
    [ApiController]
    [Route("/[controller]")]
    public class UsersController : Controller
    {
        private readonly LoanDBContext _context;

        private UserValidator userValidator = new UserValidator();
        private readonly IConfiguration _configuration;

        private UserCreateModelValidator createUserValidator = new UserCreateModelValidator();
        public UsersController(LoanDBContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }



        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserCreateModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email || u.UserName == user.UserName);
            if (existingUser != null)
            {
                return Conflict("User with this email already exists.");
            }
            var newUser = new User
            {
                Email = user.Email,
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Age = user.Age,
                UserName = user.UserName,
                WorkExperince = user.WorkExperince,

            };
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);
            newUser.Password = hashedPassword;          
            newUser.Role  = Role.User.ToString();
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return Ok("User registered successfully.");
        }


        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginModel model)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == model.UserName);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            if (!BCrypt.Net.BCrypt.Verify(model.Password, user.Password))
            {
                return Unauthorized("Invalid email or password.");
            }

            var tokenString = GenerateJwtToken(user);

            return Ok(new { Token = tokenString });
        }




        private string GenerateJwtToken(User user)
        {
            string secretKey = _configuration["SecretKey"];
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
            new Claim(ClaimTypes.Name, user.Id.ToString()),
            new Claim("Role", user.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }


       

































    }




}
