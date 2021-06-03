using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    class Time
    {
        int second;
        int minute;
        int hour;
        public Time()
        {

        }
        public Time(int hour, int minute, int second)
        {
            if (second < 0 || second > 59)
            {
                this.second = 0;
            }
            else
            {
                this.second = second;
            }
            if (minute < 0 || minute > 59)
            {
                this.minute = 0;
            }
            else
            {
                this.minute = minute;
            }
            if (hour < 0 || hour > 23)
            {
                this.hour = 0;
            }
            else
            {

                this.hour = hour;
            }
        }
        public Time(int hour, int minute)
        {
            if (minute < 0 || minute > 59)
            {
                this.minute = 0;
            }
            else
            {
                this.minute = minute;
            }
            if (hour < 0 || hour > 23)
            {
                this.hour = 0;
            }
            else
            {

                this.hour = hour;
            }
            this.second = 0;
        }
        public Time(int hour)
        {
            if (hour < 0 || hour > 23)
            {
                this.hour = 0;
            }
            else
            {

                this.hour = hour;
            }
            this.minute = 0;
            this.second = 0;
        }
        public int getHour()
        {
            return hour;
        }
        public int getMinute()
        {
            return minute;
        }
        public int getSecond()
        {
            return second;
        }
        public void setHour(int hour)
        {

            if (hour < 0 || hour > 23)
            {

            }
            else
            {

                this.hour = hour;
            }
        }
        public void setMinute(int minute)
        {
            if (minute < 0 || minute > 59)
            {

            }
            else
            {
                this.minute = minute;
            }
        }
        public void setSecond(int second)
        {
            if (second < 0 || second > 59)
            {

            }
            else
            {
                this.second = second;
            }
        }
        public void addSecond(int seconds)
        {
            int sum = second + seconds;
            if (sum > 59)
            {
                second = sum % 60;
                int minute = sum / 60;
                addMinute(minute);
            }
            else
            {
                second = sum;
            }

        }
        public void addMinute(int minutes)
        {
            int sum = minute + minutes;
            if (sum > 59)
            {
                minute = sum % 60;
                int hour = sum / 60;
                addHour(hour);
                
            }
            else
            {
                minute = sum;
            }
        }
        public void addHour(int hours)
        {
            int sum = hour + hours;
            hour = sum % 24;
        }
        public string getTime()
        {
            string hour = this.hour < 10 ? $"0{this.hour}" : $"{this.hour}";
            string minute = this.minute < 10 ? $"0{this.minute}" : $"{this.minute}";
            string second = this.second < 10 ? $"0{this.second}" : $"{this.second}";
            return $"{hour}:{minute}:{second}";
        }


    }
}
