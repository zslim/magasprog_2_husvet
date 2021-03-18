using System;

namespace Husvet
{
    class Locsolkodo: Ember
    {
        private Kolni kolniViz;
        public Kolni KolniViz
        {
            get => kolniViz;
        }
        private double alcoholConsumed;
        public double AlcoholConsumed
        {
            get => alcoholConsumed;
            private set
            {
                if(value < 0 || value > 100)
                    throw new Exception("0 és 100 közötti értéket adj meg");
                alcoholConsumed = value;
            }
        }

        public Locsolkodo(string name, DateTime birthDate, Kolni kolni, double alcoholConsumed): base(name, birthDate)
        {
                this.kolniViz = kolni;
                this.alcoholConsumed = alcoholConsumed;
        }

        public Locsolkodo(string name, Kolni kolni, double alcoholConsumed): base(name)
        {
                this.kolniViz = kolni;
                this.alcoholConsumed = alcoholConsumed;
        }

        public void Drink(int weightOfDrink, double alcoholRate)
        {
            double alcoholAmount = weightOfDrink * alcoholRate;
            AlcoholConsumed += alcoholAmount;
        }

        public bool IsTotallyWasted
        {
            get
            {
                double threshold = 0.4;
                return AlcoholConsumed >= threshold;
            }
        }
    }
}