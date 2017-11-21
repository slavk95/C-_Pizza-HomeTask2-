using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    abstract class Pizzeria
    {
        public int AmountOfPizza { get; set; }
        public string PizzaName { get; set; }
        public Pizzeria(int AmountOfPizzaValue, string PizzaNameValue)
        {
            AmountOfPizza = AmountOfPizzaValue;
            PizzaName = PizzaNameValue;
        }
        public static void Ordering()
        {
            int OrderCounter = 0;
            bool working = true;
            Pizzeria[] OrderArray = new Pizzeria[5];
            while (working)
            {
                Console.WriteLine("In order to create Grosh type array - Enter 0, if you wanna create Silpo array - Enter 1");
                int ElementType = Convert.ToInt32(Console.ReadLine());
                if (ElementType == 0)
                {
                    Console.WriteLine("Enter amount of pizza, that you want");
                    int AmountOfPizzaValue = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter pizza's name");
                    string PizzaNameValue = Console.ReadLine();

                    Console.WriteLine("You want double cheese (false - NO, true - YES");
                    bool cheese = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Please, enter pizza size");
                    int size = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("You may write the message here: ");
                    string message = Console.ReadLine();

                    Grosh GroshShop = new Grosh(AmountOfPizzaValue, PizzaNameValue, cheese, size, message);
                    OrderArray[OrderCounter] = GroshShop;

                    Console.WriteLine("If you wanna see you order, enter: show. And if you wanna continue, press any key");
                    string ShowOrder = Console.ReadLine();
                    if (ShowOrder == "show")
                    {
                        for (int i = 0; i <= OrderCounter; i++)
                        {
                            if (OrderArray[i].ToString() == "Pizza.Grosh")
                            {
                                Console.WriteLine("amount of pizza: " + ((Grosh)OrderArray[i]).AmountOfPizza);
                                Console.WriteLine("pizza's name: " + ((Grosh)OrderArray[i]).PizzaName);
                                Console.WriteLine("double cheese: " + ((Grosh)OrderArray[i]).DoubleCheese);
                                Console.WriteLine("pizza size: " + ((Grosh)OrderArray[i]).PizaSize);
                                Console.WriteLine("your message: " + ((Grosh)OrderArray[i]).Message);
                                Console.WriteLine("_______________________________________________");
                            }
                            else
                            {
                                Console.WriteLine("amount of pizza: " + ((Silpo)OrderArray[i]).AmountOfPizza);
                                Console.WriteLine("pizza's name: " + ((Silpo)OrderArray[i]).PizzaName);
                                Console.WriteLine("Cola With Pizza: " + ((Silpo)OrderArray[i]).ColaWithPizza);
                                Console.WriteLine("PhoneNumber: " + ((Silpo)OrderArray[i]).PhoneNumber);
                                Console.WriteLine("Review: " + ((Silpo)OrderArray[i]).Review);
                                Console.WriteLine("_______________________________________________");
                            }
                        }
                    }
                    OrderCounter++;
                    Console.WriteLine("Ok. We remember your order. If you wanna continue, enter : 1");
                    Console.WriteLine("If you wanna exit, enter: 0");

                    int k = Convert.ToInt32(Console.ReadLine());
                    if (k == 0)
                    {
                        working = false;
                    }
                    else
                    {
                        working = true;
                    }

                }
                else if (ElementType == 1)
                {
                    Console.WriteLine("Enter amount of pizza, that you want");
                    int AmountOfPizzaValue = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter pizza's name");
                    string PizzaNameValue = Console.ReadLine();

                    Console.WriteLine("You want Cola With Pizza (false - NO, true - YES");
                    bool ColaWithPizza = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Please, enter Phone Number");
                    int PhoneNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("You may write the Review here: ");
                    string Review = Console.ReadLine();

                    Silpo GroshShop = new Silpo(AmountOfPizzaValue, PizzaNameValue, ColaWithPizza, PhoneNumber, Review);
                    OrderArray[OrderCounter] = GroshShop;

                    Console.WriteLine("If you wanna see you order, enter: show. And if you wanna continue, press any key");
                    string ShowOrder = Console.ReadLine();
                    if (ShowOrder == "show")
                    {
                        for (int i = 0; i <= OrderCounter; i++)
                        {
                            if (OrderArray[i].ToString() == "Pizza.Silpo")
                            {
                                Console.WriteLine("amount of pizza: " + ((Silpo)OrderArray[i]).AmountOfPizza);
                                Console.WriteLine("pizza's name: " + ((Silpo)OrderArray[i]).PizzaName);
                                Console.WriteLine("Cola With Pizza: " + ((Silpo)OrderArray[i]).ColaWithPizza);
                                Console.WriteLine("PhoneNumber: " + ((Silpo)OrderArray[i]).PhoneNumber);
                                Console.WriteLine("Review: " + ((Silpo)OrderArray[i]).Review);
                                Console.WriteLine("_______________________________________________");
                            }
                            else
                            {
                                Console.WriteLine("amount of pizza: " + ((Grosh)OrderArray[i]).AmountOfPizza);
                                Console.WriteLine("pizza's name: " + ((Grosh)OrderArray[i]).PizzaName);
                                Console.WriteLine("double cheese: " + ((Grosh)OrderArray[i]).DoubleCheese);
                                Console.WriteLine("pizza size: " + ((Grosh)OrderArray[i]).PizaSize);
                                Console.WriteLine("your message: " + ((Grosh)OrderArray[i]).Message);
                                Console.WriteLine("_______________________________________________");
                            }
                        }
                    }
                    OrderCounter++;
                }
                if (OrderCounter > 4)
                {
                    working = false;
                }
            }
        }
    }
    
    
}
