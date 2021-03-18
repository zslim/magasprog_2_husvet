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
    }
}