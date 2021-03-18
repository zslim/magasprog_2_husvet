using System;
using System.Collections.Generic;
using System.Linq;

namespace Husvet
{
    class Kocsma
    {
        private List<Locsolkodo> locsolkodok;

        public int CountOfPeople
        {
            get
            {
                return locsolkodok.Count;
            }
        }

        public Kocsma()
        {
            locsolkodok = new List<Locsolkodo>();
        }
        
        public List<Locsolkodo> PeopleWithKolni(Kolni kolni)
        {
            return locsolkodok.Where(ember => ember.KolniViz == kolni).ToList();
        }

        public void AddPerson(Locsolkodo person)
        {
            locsolkodok.Add(person);
        }

        public void FillFromFile(string filePath)
        {
            List<string[]> fileContent = FileUtil.ReadFile(filePath);

            foreach (var row in fileContent)
            {
                DateTime birthDate = DateTime.Parse(row[1]);
                Kolni kolni = (Kolni) Enum.Parse(typeof(Kolni), row[2]);
                double alcoholConsumed = double.Parse(row[4]);
                
                Locsolkodo person = new Locsolkodo(
                    name: row[0], 
                    birthDate: birthDate,
                    kolni: kolni,
                    alcoholConsumed: alcoholConsumed);
                
                AddPerson(person);
            }
        }
    }
}