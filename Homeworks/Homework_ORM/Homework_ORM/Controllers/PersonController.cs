using Homework_ORM.Data;
using Homework_ORM.Domain;
using Homework_ORM.Validators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_ORM.Controllers
{
   

        [ApiController]
        [Route("/[controller]")]
        public class PersonController : Controller
        {
            private readonly PersonContext _context;
            public PersonController(PersonContext context)
            {
                _context = context;
            }


            [HttpPost("POST")]
            public async Task<ActionResult<Person>> CreateUser(Person person)
            {
                var personValidator = new PersonValidator();
                if (!personValidator.Validate(person).IsValid)
                {

                    var listOfMessages = personValidator.Validate(person).Errors;

                    string listOfMessagesText = string.Join(", ", listOfMessages);
                    return BadRequest(listOfMessagesText);
                }
                else
                {

                    SavePerson(person);
                    await _context.SaveChangesAsync();

                    return CreatedAtAction("GetPersons", new { id = person.Id }, person);

                }

            }


            [HttpGet("GET")]

            public async Task<ActionResult<IEnumerable<Person>>> GetPersons()
            {
                var persons = await _context.Persons.ToListAsync();

                if (persons.FirstOrDefault() != null)
                {
                    return Accepted(persons);
                }
                else
                {
                    return BadRequest();
                }


            }

            [HttpGet("GET/{id}")]

            public Task<ActionResult<Person>> GetPersonById(int id)
            {
                var person = _context.Persons.First(x => x.Id == id);

                if (person == null)
                {
                    return Task.FromResult<ActionResult<Person>>(BadRequest($"Record with id {id}  does not exist!")); ;
                }
                else
                {
                    return Task.FromResult<ActionResult<Person>>(Ok(person));
                }


            }


            [HttpGet("higherSalary")]

            public IActionResult SalaryHigher([FromQuery] Person person) =>
                         Ok(_context.Persons.Where(x => x.Salary > person.Salary));


            [HttpDelete("DELETE/{id}")]
            public async Task<ActionResult> DeletePersonById(int id)
            {
                var personToDelete = await GetPersonById(id);

                if (personToDelete == null)
                {
                    return BadRequest($"Record with id {id}  does not exist!"); ;
                }
                else
                {
                    _context.Persons.Remove((Person)personToDelete.Value);
                    return Accepted("Record deleted!");
                }
            }

            [HttpDelete("PUT/{id}")]
            public IActionResult UpdatePersonById(Person person, int Id)
            {
            var personExist = GetPersonById(Id);
                var personValidator = new PersonValidator();
                if (personValidator.Validate(person).IsValid && personExist!= null)
                {
                    person.Id = Id;
                    _context.Persons.Update(person);
                    return Ok(person);
                }
                else
                {
                    var listOfMessages = personValidator.Validate(person).Errors;

                    string listOfMessagesText = string.Join(", ", listOfMessages);
                    return BadRequest(listOfMessagesText);
                }

            }






            private void SavePerson(Person person)
            {


                _context.Persons.Add(person);

            }














        }
    
}
