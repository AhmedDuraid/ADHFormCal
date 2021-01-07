using System;
using System.Collections.Generic;

namespace ADHFormCalAPI.ErrorHandling
{
    public class CalculationValidation : ICalculationValidation
    {
        public void CanNotBeZero(double value, string valueName)
        {
            if (value == 0)
            {
                throw new ArgumentException($"{valueName} can not be 0");
            }
        }
        public void CanNotBeZero(double valueOne, double valueTwo, string valueOneName, string valueTwoName)
        {
            if (valueOne == 0 || valueTwo == 0)
            {
                throw new ArgumentException($"{valueOneName} or {valueTwoName} can not be 0");
            }
        }
        public void DivideByZero(double value, string message)
        {
            if (value == 0)
            {
                throw new DivideByZeroException($"Can Not Divided by ZERO: {message}");
            }

        }
        public void LessThanZero(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Value can not be less than 0");
            }
        }
        public void LessThanZero(double value, string valueName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{valueName} can not be less than 0");
            }
        }
        public void LessThanZero(double valueOne, double valueTwo, string valueOneName, string valueTwoName)
        {
            if (valueOne < 0 || valueTwo < 0)
            {
                throw new ArgumentException($"{valueOneName} or {valueTwoName} can not be less than 0");
            }
        }
        public void LessThanZero(List<double> listValues, List<string> valuesName)
        {
            for (int i = 0; i < listValues.Count; i++)
            {
                if (listValues[i] < 0)
                {
                    throw new ArgumentException($"{valuesName[i]} can not be less than 0");
                }
            }
        }

        public void ListHasNoValues(List<double> values)
        {
            if (values.Count == 0)
            {
                throw new ArgumentException("List Has No Values");
            }
        }
        public void ListHasNoValues(List<int> values)
        {
            if (values.Count == 0)
            {
                throw new ArgumentException("List Has No Values");
            }
        }
        public void ListLimit(List<int> list, int limit)
        {
            if (list.Count > limit)
            {
                throw new ArgumentException($"List Are Limited To {limit} Numbers");
            }
        }

    }
}
