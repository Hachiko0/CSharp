using System;
using System.Collections.Generic;

namespace _01.DefineClassesPartOne
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        public static GSM IPhone4S;
        private List<Call> callHistory;
        private const decimal pricePerMinute = 0.37m;

        //static method 
        public static GSM CreateIphone()
        {
            IPhone4S = new GSM("Iphone", "Apple");
            IPhone4S.Battery = new Battery(10, 5);
            IPhone4S.Display = new Display("180x220", 50);
            IPhone4S.Owner = "Unknown";
            IPhone4S.price = 1300;
            return IPhone4S;
        }
        //static constructor
        static GSM()
        {
            IPhone4S = new GSM("Iphone", "Apple");
            IPhone4S.Battery = new Battery(5, 2);
            IPhone4S.Display = new Display("160x180", 50);
            IPhone4S.Owner = "Mario Mariov";
            IPhone4S.Price = 1600;
        }

        //instance constructors
        public GSM(string model, string manufacturer)
        {
            this.CallHistory = new List<Call>();
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner, battery)
        {
            this.Display = display;
        }

        //public static GSM IPhone4S
        //{
        //    get
        //    {
        //        return iPhone4S;
        //    }
        //}

        //instance properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The model cant have null value");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The manufacturer cant have null value");
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Price cant be negative number");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name cant have null value");
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value cant be null");
                }
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value cant be null");
                }
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value cant be null");
                }
                this.callHistory = value;
            }
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void RemoveCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void RemoveCall(int index)
        {
            this.CallHistory.RemoveAt(index);
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal CalculateTotalPriceOfCalls()
        {
            int allSeconds = 0;
            foreach (var item in this.CallHistory)
            {
                allSeconds += item.Duration;
            }
            int minutes = allSeconds / 60;
            decimal totalPrice = minutes * pricePerMinute;
            //ако има остатък например 5 минути и 40 секунди , тези 40 секунди се броят за 1 минута за това добавяме
            // още 0.37 към цената
            if (allSeconds % 60 != 0)
            {
                totalPrice += pricePerMinute;
            }
            return totalPrice;
        }

        public int FindLongestCallDuration()
        {
            int longestCall = this.CallHistory[0].Duration;
            int index = 0;
            for (int i = 1; i < this.CallHistory.Count; i++)
            {
                if (this.CallHistory[i].Duration > longestCall)
                {
                    longestCall = this.CallHistory[i].Duration;
                    index = i;
                }
            }
            return index;
        }

        public override string ToString()
        {
            string result = string.Format("Model : {0} \r\nManufacturer : {1} \r\nPrice : {2} \r\nOwner : {3}" +
                "\r\nBattery Type : {4} \r\nHours Idle : {5} \r\nHours Talk : {6} \r\nDisplay size : {7} \r\nNumber of colors : {8}",
                this.model, this.manufacturer, this.price, this.owner, this.battery.BatteryType, this.battery.HoursIdle,
                this.battery.HoursTalk, this.display.Size, this.display.NumberOfColors);
            return result;
        }
    }
}