using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._4
{
    interface IAtack
    {
        void Atack();
    }
    interface IHealing
    {
        void Heal();
    }
    class Warrior: IAtack
    {
        public void Atack()
        {
            Console.WriteLine("Атакую противника мечом!");
        }
    }
    class Wizard: IAtack, IHealing
    {
        public void Atack()
        {
            Console.WriteLine("Атакую противника магическим зарядом!");
        }
        public void Heal()
        {
            Console.WriteLine("С помощью магии вылечил раненного война...");
            Console.WriteLine("С помощью магии вылечил своё ранение...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Класс - воин:");
            Warrior[] war = { new  Warrior() };
            foreach (Warrior w in war)
            {
                w.Atack();
            }

            Console.WriteLine();

            Console.WriteLine("Класс - маг:");
            Wizard[] wiz = { new Wizard() };
            foreach (Wizard w in wiz)
            {
                w.Atack();
                w.Heal();
            }
        }
    }
}
