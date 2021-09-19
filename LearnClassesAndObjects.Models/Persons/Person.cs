using System;

namespace LearnClassesAndObjects.Models.Persons
{
    public class Person
    {
        private double height;
        private double weight;
        private string firstName;
        private string lastName;
        private string middleName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (IsValid(value))
                {
                    firstName = value;
                }
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (IsValid(value))
                {
                    lastName = value;
                }
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                if (IsValid(value))
                {
                    middleName = value;
                }
            }
        }
        public Gender Gender { get; set; }
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - Birthday.Year;
                if (Birthday.Month == DateTime.Now.Month)
                {
                    if (Birthday.Day < DateTime.Now.Day)
                    {
                        return age - 1;
                    }
                    else
                        return age;
                }

                if (Birthday.Month < DateTime.Now.Month)
                {
                    return age;
                }

                if (Birthday.Month > DateTime.Now.Month)
                {
                    return age - 1;
                }

                return age;
            }

        }
        public string Email { get; set; }
        public Guid Id { get; set; }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (IsValid(value))
                {
                    height = value;
                }
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (IsValid(value))
                {
                    weight = value;
                }
            }
        }
        public DateTime Birthday { get; set; }
        public Person()
        {

        }
        public Person(Guid id, string firstName, string lastName, string middleName, Gender gender, DateTime birthday, double height, double weight, string email = null)
        {
            if (IsValid(firstName))
            {
                FirstName = firstName;
            }
            else
            {
                FirstName = "DefaultFirstName";
            }
            if (IsValid(lastName))
            {
                LastName = lastName;
            }
            else
            {
                LastName = "DefaultLastName";
            }
            if (IsValid(middleName, false))
            {
                MiddleName = middleName;
            }
            else
            {
                MiddleName = "DefaultMiddleName";
            }
            Gender = gender;
            if (IsValid(height))
            {
                Height = height;
            }
            else
            {
                Height = 0;
            }
            if (IsValid(weight))
            {
                Weight = weight;
            }
            else
            {
                Weight = 0;
            }
            Email = email;
            Id = id;
        }
        public string GetInfo()
        {
            return $"{LastName } {FirstName} {MiddleName} , {Gender} , {Age} years old, height - {Height}cm, weight - {Weight}";
        }
        public string InfoForWrite()
        {
            return $"{FirstName}|{LastName}|{MiddleName}|{Gender}|{Birthday.ToString("dd.MM.yyyy")}|{Height}|{Weight}|{Id}";
        }
        public string GetFullName()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
        public string GetInitial()
        {
            return $"{LastName} {FirstName[0]}.{MiddleName[0]}.";
        }
        public bool IsValid(int age)
        {
            return age >= 0;
        }
        public bool IsValid(double heightOrWeight)
        {
            return heightOrWeight > 0;
        }
        public bool IsValid(string str, bool checkEmpty = true)
        {
            if (checkEmpty)
            {
                return str != null && str != string.Empty;
            }
            else
            {
                return str != null;
            }




        }
    }
}
