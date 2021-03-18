using System;

namespace Husvet
{
    class Ember
    {
        private string name;
        public string Name
        {
            get => name;
            private set
            {
                if(value.Length < 3) 
                {
                    throw new Exception("Túl rövid név: 3 karakternél rövidebb");
                }
                name = value;
            }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            private set
            {
                if(value > DateTime.Today)
                    throw new Exception("Helytelen születési dátum: az idő jövőbeli");
            }
        }

        public int Age
        {
            get
            {
                int daysInYear = 365;
                double ageDays = (DateTime.Today - birthDate).TotalDays;
                return (int) Math.Floor(ageDays / daysInYear);
            }
        }

        public Ember(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public Ember(string name)
        {
            Name = name;
            BirthDate = DateTime.Today;
        }
    }
    
}