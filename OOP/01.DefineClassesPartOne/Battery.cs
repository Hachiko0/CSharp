using System;

namespace _01.DefineClassesPartOne
{
    public enum BatteryType
    {
        NiMH, LiIon, NiCd
    }


    public class Battery
    {
        private BatteryType batteryType;
        private int hoursIdle;
        private int hoursTalk;
        public Battery(int hoursIdle)
        {
            this.HoursIdle = hoursIdle;
        }

        public Battery(int hoursIdle, int hoursTalk)
            : this(hoursIdle)
        {
            this.HoursTalk = hoursTalk;
        }

        public Battery(int hoursIdle, int hoursTalk, BatteryType batteryType)
            : this(hoursIdle, hoursTalk)
        {
            this.BatteryType = batteryType;
        }
        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }
        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Hours idle cant be a negative number");
                }
                this.hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Hours talk cant be a negative number");
                }
                this.hoursTalk = value;
            }
        }
    }
}


