using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class ThoiGian
    {
        private int day, month, year;
        private int hour, minute, second;
       
        public int Day
        {
            get => day;
            set
            {
                if (value >= 1 && value <= 30)
                    day = value;
                else
                    throw new ArgumentOutOfRangeException("Nhap sai!");
            }
        }
        public int Month
        {
            get => month;
            set
            {
                if (value >= 1 && value <= 30)
                    month = value;
                else throw new ArgumentOutOfRangeException("Nhap sai!");
            }
        }
        public int Year { get => year; set => year = value; }
        public int Hour
        {
            get => hour;
            set
            {
                if (value > 0 && value < 24)
                    hour = value;
                else
                    hour = 0;
            }
        }
        public int Minute
        {
            get => minute;
            set
            {
                if (value > 0 && value < 60)
                    minute = value;
                else
                    minute = 0;
            }
        }
        public int Second
        {
            get => second;
            set
            {
                if (value > 0 && value < 60) second = value;
                else
                    second = 0;
            }
        }
        public ThoiGian() {
            this.Year = 2014;
            this.Month = 09;
            this.Day = 20;
            Hour = 10;
            Minute = 30;
            Second = 40;
        }
        public ThoiGian(int day, int month, int year, int hour, int minute, int second)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public ThoiGian(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public ThoiGian(ThoiGian tg)
        {
            Day = tg.Day;
            Month = tg.Month;
            Year = tg.Year;
            Hour = tg.Hour;
            Second = tg.Second;
            Minute = tg.Minute;
        }
        public ThoiGian(System.DateTime tg)
        {
            Year = tg.Year;
            Month = tg.Month;
            Day = tg.Day;
            Hour = tg.Hour; 
            Minute = tg.Minute;
            Second = tg.Second;
        }
        public void HienThi()
        {
            Console.WriteLine("Ngay:{0}/{1}/{2}", Day, Month, Year);
            Console.WriteLine("Gio:{0}/{1}/{2}", Hour, Minute, Second);
        }

    }
}
