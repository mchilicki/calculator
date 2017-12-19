using Calculator.Model.Entity;
using Calculator.Model.Operation;
using Calculator.Model.State;

namespace Calculator.Model
{
    class CalculationManager
    {
        private CalculationState _calculationState = new InsertFirstNumberState();                 

        public string OperationSign { get { return _calculationState.Operation.OperationSign; } }

        public Number FirstNumber { get { return _calculationState.Operation.FirstNumber; } }

        // What with SecondNumber?

        public Number Execute()
        {
            return _calculationState.Operation.Execute();
        }

        

        /*double result;
        double.TryParse(_firstNumber, out result);
        Operation = OneParameterOperationFactory.Create(
                                DetermineOperationType(
                                    operationSign.ToString()), 
                                new Number(result));*/

    }
}
