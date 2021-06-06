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

        //Закрытые поля
        private int second;
        private int minute;
        private int hour;
        
        //Свойства для закрытых полей
        public int Second
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
        public int Minute
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
        public int Hour
        {
            get
            {
                return this.hour;
            }
            set
            {
                if (hourIsValid(value))
                {
                    this.hour = value;
                }
            }
        }

        //Конструкторы
        public Time()
        {

        }
        public Time(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public Time(int hour, int minute)
        {
            if (hourIsValid(hour))
            {
                this.Hour = hour;
            }
            else
            {
                this.Hour = 0;
            }

            if (minuteIsValid(minute))
            {
                this.Minute = minute;
            }
            else
            {
                this.Minute = 0;
            }

            this.Second = 0;
        }
        public Time(int hour)
        {
            if (hourIsValid(hour))
            {
                this.Hour = hour;
            }
            else
            {
                this.Hour = 0;
            }

            this.Minute = 0;
            this.Second = 0;
        }

        //Основная группа методов
        public void addSecond(int seconds)
        {
            int sum = Second + seconds;
            if (!secondIsValid(sum))
            {
                Second = sum % 60;
                int minute = sum / 60;
                addMinute(minute);
            }
            else
            {
                Second = sum;
            }

        }
        public void addMinute(int minutes)
        {
            int sum = Minute + minutes;
            if (!minuteIsValid(sum))
            {
                Minute = sum % 60;
                int hour = sum / 60;
                addHour(hour);

            }
            else
            {
                Minute = sum;
            }
        }
        public void addHour(int hours)
        {
            int sum = Hour + hours;
            Hour = sum % 24;
        }
        public string getTime()
        {
            string hour = getDigitalFormat(this.Hour);
            string minute = getDigitalFormat(this.Minute);
            string second = getDigitalFormat(this.Second);

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
