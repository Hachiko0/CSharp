using System;

namespace _02.DefineClassesPartTwo
{
    class MatrixException : Exception
    {
        public MatrixException()
            : base()
        {

        }

        public MatrixException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public MatrixException(string message)
            : base(message, null)
        {
        }
    }
}
