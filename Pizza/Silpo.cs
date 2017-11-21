using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Silpo : Pizzeria
    {
        public bool ColaWithPizza { get; set; } // 1 -yes, 0 - not
        public int PhoneNumber { get; set; }
        public string Review { get; set; }
        public Silpo(int AmountOfPizzaValue, string PizzaNameValue, bool ColaWithPizza, int PhoneNumber, string Review)
            : base(AmountOfPizzaValue, PizzaNameValue)
        {
            this.ColaWithPizza = ColaWithPizza;
            this.PhoneNumber = PhoneNumber;
            this.Review = Review;
        }
    }
}
