using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Grosh : Pizzeria
    {
        public bool DoubleCheese { get; set; } //Cheeze - 1 -yes, 0 - not
        public int PizaSize { get; set; }
        public string Message { get; set; }
        public Grosh(int AmountOfPizzaValue, string PizzaNameValue, bool DoubleCheese, int PizaSize, string Message)
            : base(AmountOfPizzaValue, PizzaNameValue)
        {
            this.DoubleCheese = DoubleCheese;
            this.PizaSize = PizaSize;
            this.Message = Message;
        }
    }
}
