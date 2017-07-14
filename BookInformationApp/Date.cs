using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInformationApp
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int GetDay()
        {
            return this.day;
        }         
        
        public int GetMonth()
        {
            return this.month;
        }

        public int GetYear()
        {
            return this.year;
        }

        public void SetDay(int day)
        {
            this.day = day;
        }

        public void SetMonth(int month)
        {
            this.month = month;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }

        public void SetDate(int day, int month, int year )
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public string toString()
        {
            return string.Format("%02d:%02d:%02d", day, month, year);
        }
    }
}
