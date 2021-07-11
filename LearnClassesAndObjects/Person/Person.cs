using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
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
                return this.firstName;
            }
            set
            {
                if (IsValid(value))
                {
                    this.firstName = value;
                }
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (IsValid(value))
                {
                    this.lastName = value;
                }
            }
        }
        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (IsValid(value))
                {
                    this.middleName = value;
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
        public int Id { get; set; }

        public double Height
        {
            get
            {
                return this.height;
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
                return this.weight;
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
        public Person(int id ,string firstName, string lastName, string middleName, Gender gender, DateTime birthday, double height, double weight, string email = null)
        {
            if (IsValid(firstName))
            {
                this.FirstName = firstName;
            }
            else
            {
                this.FirstName = "DefaultFirstName";
            }
            if (IsValid(lastName))
            {
                this.LastName = lastName;
            }
            else
            {
                this.LastName = "DefaultLastName";
            }
            if (IsValid(middleName,false))
            {
                this.MiddleName = middleName;
            }
            else
            {
                this.MiddleName = "DefaultMiddleName";
            }
            this.Gender = gender;
            if (IsValid(height))
            {
                this.Height = height;
            }
            else
            {
                this.Height = 0;
            }
            if (IsValid(weight))
            {
                this.Weight = weight;
            }
            else
            {
                this.Weight = 0;
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
