using System;

namespace Lesson10practice
{
    class Program
    {
        static void Main(string[] args)
        {
            PepperoniPizza pepperoni = new PepperoniPizza();
            pepperoni.Prepare();

            CheesePizza cheese = new CheesePizza();
            cheese.Prepare();

            Oven theOven = new Oven();
            theOven.Bake(cheese);
            theOven.Bake(pepperoni);

            PasswordGenerator passwordGen = new PasswordGenerator();
            string password = passwordGen.CreatePassword();
            Console.WriteLine("New Password is " + password);
        }
    }
}
