using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator
{
    public class RPNCalculator
    {
        String expression;
        Int64 value1;
        Int64 value2;
        Int64 result = 0;

        private Stack<Int64> operands = new Stack<Int64>();
        private Stack<string> operators = new Stack<string>();
        List<string> tokens;

        public object SolveEquation(string equation)
        {
             tokens = new List<string>(equation.Split(' '));

            if (CheckEquation(equation))
            {
                while(operators.Count > 0)
                {
                    string token = operators.Pop();
                    switch(token)
                    {
                        case "+":
                            result = new Addition().Calculate(operands.Pop(), operands.Pop());
                            break;
                        case "-":
                            value1 = operands.Pop();
                            value2 = operands.Pop();
                            result = new Subtraction().Calculate(value2, value1);
                            break;
                        case "*":
                            result = new Multiply().Calculate(operands.Pop(), operands.Pop());
                            break;
                        case "/":
                            value1 = operands.Pop();
                            value2 = operands.Pop();
                            result = new Divide().Calculate(value2, value1);
                            break;
                        case "!":
                            result = new Factorial().Calculate(operands.Pop());
                            break;
                    } 
                    operands.Push(result);
                }
                return operands.Pop();
            }
            else
            {
                return "Invalid String!";
            }
        }

        private bool CheckEquation(string equation)
        {
            List<string> tempToks = new List<string>(equation.Split(' '));
            operands.Clear();
            operators.Clear();

            if (IsEmptyString(equation))
                return false;

            foreach (string token in tempToks)
            {
                Int64 value;
                bool res = Int64.TryParse(token, out value);
                if (res == true)
                {
                    operands.Push(value);
                    continue;
                }
                else
                {
                    operators.Push(token);
                }
            }
            if (!checkOperatorsAndOperands())
                return false;

            return true;

        }

        private bool checkOperatorsAndOperands()
        {
            if ((!EquationContainsUnaryOperator()) && (operators.Count == (operands.Count - 1)))
                return true;
            else if (EquationContainsUnaryOperator() && (operators.Count == operands.Count))
                return true;

            return false;
        }

        private bool IsEmptyString(string equation)
        {
            return equation == String.Empty;
        }

        private bool EquationContainsUnaryOperator()
        {
            return (operators.Contains("!") || operators.Contains("%"));
        }
    }
}
