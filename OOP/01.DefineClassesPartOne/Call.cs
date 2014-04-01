using System;
using System.Collections.Generic;

namespace _01.DefineClassesPartOne
{
    public class Call
    {
        private string date;
        private string time;
        private string dialedPhoneNumber;
        private int duration;
        public Call(string date, string time, string dialedPhoneNumber, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }
        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                //03.04.2013
                if (value.Length != 10)
                {
                    throw new IndexOutOfRangeException("The date is not correct");
                }
                else if (value == null)
                {
                    throw new ArgumentNullException("Cant have null value");
                }
                this.date = value;
            }
        }
        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cant have null value");
                }
                this.time = value;
            }
        }
        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            set
            {
                if (value.Length != 12)
                {
                    throw new ArgumentOutOfRangeException("The number must be 10 digits long");
                }
                this.dialedPhoneNumber = value;
            }
        }
        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Seconds cant be less than 0");
                }
                this.duration = value;
            }
        }
        public override string ToString()
        {
            string result = string.Format("Date of call : {0}\r\nTime of call : {1}\r\nDialed phone number : {2}\r\nDuration : {3} seconds",
                this.date, this.time, this.dialedPhoneNumber, this.duration);
            return result;
        }
    }
}
