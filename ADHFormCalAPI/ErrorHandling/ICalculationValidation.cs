using System.Collections.Generic;

namespace ADHFormCalAPI.ErrorHandling
{
    public interface ICalculationValidation
    {
        void CanNotBeZero(double value, string valueName);
        void CanNotBeZero(double valueOne, double valueTwo, string valueOneName, string valueTwoName);
        void DivideByZero(double value, string message);
        void LessThanZero(double value);
        void LessThanZero(double value, string valueName);
        void LessThanZero(double valueOne, double valueTwo, string valueOneName, string valueTwoName);
        void LessThanZero(List<double> listValues, List<string> valuesName);
        void ListHasNoValues(List<double> values);
        void ListHasNoValues(List<int> values);
        void ListLimit(List<int> list, int limit);
    }
}