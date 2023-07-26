using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Homework_22.HR
{
    public class ExpressionHelper
    {
        public static Delegate BuildLambda(string formula, string[] variables)
        {
            var parameters = variables.Select(par => Expression.Parameter(typeof(double), par)).ToList();
            var expr = BuildExpressionTree(formula.Split(' '), parameters);

            return Expression.Lambda(expr, parameters).Compile();
        }

        private static Expression BuildExpressionTree(IEnumerable<string> splittedFormula, List<ParameterExpression> parameters)
        {
            var stack = new Stack<Expression>();

            foreach (var part in splittedFormula)
            {
                if (double.TryParse(part, out var num))
                {
                    stack.Push(Expression.Constant(num));
                }
                else if (parameters.Exists(x => x.Name == part))
                {
                    stack.Push(parameters.First(x => x.Name == part));
                }
                else
                {
                    var left = stack.Pop();
                    var right = stack.Pop();

                    switch (part)
                    {
                        case "+":
                            stack.Push(Expression.Add(left, right));
                            break;
                        case "-":
                            stack.Push(Expression.Subtract(left, right));
                            break;
                        case "*":
                            stack.Push(Expression.Multiply(left, right));
                            break;
                        case "/":
                            stack.Push(Expression.Divide(left, right));
                            break;
                        default:
                            throw new InvalidOperationException("");
                    }
                }
            }

            return stack.Pop();
        }
    }

}
