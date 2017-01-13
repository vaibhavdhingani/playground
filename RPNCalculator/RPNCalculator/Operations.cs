using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator
{
    protected enum OperatorType { Unary = 1, Binary };

    public class Addition : BinaryOperators
    {
        public Int64 Calculate(Int64 value1, Int64 value2)
        {
            return value1 + value2;
        }
    }

    public class Subtraction : BinaryOperators
    {
        public Int64 Calculate(Int64 value1, Int64 value2)
        {
            return value1 - value2;
        }
    }

    public class Multiply : BinaryOperators
    {
        public Int64 Calculate(Int64 value1, Int64 value2)
        {
            return value1 * value2;
        }
    }

    public class Divide : BinaryOperators
    {
        public Int64 Calculate(Int64 value1, Int64 value2)
        {
            return value1 / value2;
        }
    }

    public class Factorial : UnaryOperators
    {
        public Int64 Calculate(Int64 value)
        {
            return FactorialN(value);
        }

        private Int64 FactorialN(long p)
        {
            if (p < 2)
                return 1;
            return (p * FactorialN(p - 1));
        }
    }
    public interface Operators
    {
    }

    public interface BinaryOperators : Operators
    {
        Int64 Calculate(Int64 value1, Int64 value2);
        public OperatorType GetOperatortType()
        {
            return OperatorType.Binary;
        }
    }

    public interface UnaryOperators : Operators
    {
        Int64 Calculate(Int64 value);
        public OperatorType GetOperatortType()
        {
            return OperatorType.Unary;
        }
    }

    public class OperatorFactory
    {
        private Dictionary<string, Operators> factory = new Dictionary<string, Operators> { { "+", new Addition() }, 
                                                                                      { "-", new Subtraction() },
                                                                                      { "*", new Multiply() },
                                                                                      { "/", new Divide() },
                                                                                      { "!", new Factorial() }};

        public Operators GetOperation(string token)
        {
            return factory[token];
        }
    }
}
