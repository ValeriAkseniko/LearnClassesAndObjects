namespace LearnClassesAndObjects.Models.Commones
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
                return second;
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
                return minute;
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
                return hour;
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
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public Time(int hour, int minute)
        {
            if (hourIsValid(hour))
            {
                Hour = hour;
            }
            else
            {
                Hour = 0;
            }

            if (minuteIsValid(minute))
            {
                Minute = minute;
            }
            else
            {
                Minute = 0;
            }

            Second = 0;
        }
        public Time(int hour)
        {
            if (hourIsValid(hour))
            {
                Hour = hour;
            }
            else
            {
                Hour = 0;
            }

            Minute = 0;
            Second = 0;
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
            string hour = getDigitalFormat(Hour);
            string minute = getDigitalFormat(Minute);
            string second = getDigitalFormat(Second);

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
