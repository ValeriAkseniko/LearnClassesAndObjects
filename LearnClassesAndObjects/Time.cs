using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    class Time
    {
        //Выделены константы, чтобы не было магических чисел
        private const int MAXHOUR = 23;
        private const int MAXMINUTE = 59;
        private const int MAXSECOND = 59;

        //Свойства
        public int second
        {
            get
            {
                return this.second;
            }
            set
            {
                if (secondIsValid(value))
                {
                    second = value;
                }
            }
        }
        public int minute
        {
            get
            {
                return this.minute;
            }
            set
            {
                if (minuteIsValid(value))
                {
                    minute = value;
                }
            }
        }
        public int hour
        {
            get
            {
                return this.hour;
            }
            set
            {
                if (hourIsValid(value))
                {
                    hour = value;
                }
            }
        }

        //Конструкторы
        public Time()
        {

        }
        public Time(int hour, int minute, int second)
        {
            if (hourIsValid(hour))
            {
                this.hour = hour;
            }
            else
            {
                this.hour = 0;
            }

            if (minuteIsValid(minute))
            {
                this.minute = minute;
            }
            else
            {
                this.minute = 0;
            }

            if (secondIsValid(second))
            {
                this.second = second;
            }
            else
            {
                this.second = 0;
            }
        }
        public Time(int hour, int minute)
        {
            if (hourIsValid(hour))
            {
                this.hour = hour;
            }
            else
            {
                this.hour = 0;
            }

            if (minuteIsValid(minute))
            {
                this.minute = minute;
            }
            else
            {
                this.minute = 0;
            }

            this.second = 0;
        }
        public Time(int hour)
        {
            if (hourIsValid(hour))
            {
                this.hour = hour;
            }
            else
            {
                this.hour = 0;
            }

            this.minute = 0;
            this.second = 0;
        }

        //Основная группа методов
        public void addSecond(int seconds)
        {
            int sum = second + seconds;
            if (secondIsValid(sum))
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
            if (minuteIsValid(sum))
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
            string hour = getDigitalFormat(this.hour);
            string minute = getDigitalFormat(this.minute);
            string second = getDigitalFormat(this.second);

            return $"{hour}:{minute}:{second}";
        }

        //Приватные методы, которые используются для основных методов, пользователям объекта незачем иметь к ним доступ 
        private string getDigitalFormat(int value)
        {
            return value < 10 ? $"0{value}" : $"{value}";
        }
        private bool hourIsValid(int hours)
        {
            return hours >= 0 && hours <= MAXHOUR;
        }
        private bool minuteIsValid(int minutes)
        {
            return minutes >= 0 && minutes <= MAXMINUTE;
        }
        private bool secondIsValid(int seconds)
        {
            return seconds >= 0 && seconds <= MAXSECOND;
        }
    }
}
