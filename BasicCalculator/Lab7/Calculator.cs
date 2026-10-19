using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    internal class Calculator
    {
        public decimal Value { get; private set; }
        public decimal PreviousValue { get; private set; }
        public string Operation { get; private set; } = "";
        public string PreviousOperation { get; private set; } = "";
        public decimal SecondOperand { get; private set; }
        public void SetValue(decimal value)
        {
            Value = value;
        }
        public void SetOperation(string operation)
        {
            PreviousValue = Value;
            Operation = operation;
        }
        public decimal Calculate(decimal secondOperand)
        {
            SecondOperand = secondOperand;

            switch(Operation)
            {
                case "+":
                    Value = PreviousValue + SecondOperand;
                    break;
                case "-":
                    Value = PreviousValue - SecondOperand;
                    break;
                case "*":
                    Value = PreviousValue * SecondOperand;
                    break;
                case "/":
                    if (SecondOperand == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    Value = PreviousValue / SecondOperand;
                    break;
                default:
                    throw new InvalidOperationException("Invalid operation.");
            }
            PreviousOperation = Operation;
            Operation = "";
            return Value;
        }
        public decimal RepeatOperation()
        {
            if (PreviousOperation == "")
            {
                return Value;
            }
            Operation = PreviousOperation;
            return Calculate(SecondOperand);
        }
        public decimal SquareRoot()
        {
            if (Value < 0)
            {
                throw new InvalidOperationException("Cannot calculate square root of a negative number.");
            }
            Value = (decimal)Math.Sqrt((double)Value);
            return Value;
        }
        public decimal Reciprocal()
        {
            if (Value == 0)
            {
                throw new DivideByZeroException("Cannot calculate reciprocal of zero.");
            }
            Value = 1m / Value;
            return Value;
        }
        public void ChangeSign()
        {
            Value = -Value;
        }
        public void Clear()
        {
            Value = 0;
            PreviousValue = 0;
            Operation = "";
            PreviousOperation = "";
            SecondOperand = 0;
        }
    }
}
