using System;

namespace _01.DefineClassesPartOne
{
    public class Display
    {
        private string size;
        private int numberOfColors;

        public Display()
        {
            this.size = "180x120";
            this.numberOfColors = 32000;
        }

        public Display(string size)
        {
            this.Size = size;
        }

        public Display(string size, int numberOfColors)
            : this(size)
        {
            this.NumberOfColors = numberOfColors;
        }
        public string Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The size must have a value");
                }
                this.size = value;
            }
        }
        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Cant be less than zero");
                }
                this.numberOfColors = value;
            }
        }
    }
}
