using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Model.Entity;

namespace Calculator.Model.Operation.Base
{
    class NullFastOperation : FastOperation
    {
        public NullFastOperation(Number number) : base(Number.EmptyNumber)
        {
        }

        public override string OperationSign { get { return string.Empty; } }

        public override Number Execute() { return Number.EmptyNumber; }
    }
}
