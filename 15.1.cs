using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1
{
    interface IWorking
    {
        void Work();
    }
    interface IReloading
    {
        void Reload();
    }
    class Robot: IWorking, IReloading
    {
        private string name;
        private int energy;
            public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value >= 0 && value <= 100) { energy = value; }
                else
                {
                    Console.WriteLine("Энергия должна быть от 0 до 100!");
                }
            }
        }
        public Robot(string name, int energy)
        {
            Name = name;
            Energy = energy;
        }
        public void Work()
        {
            if (Energy >= 20)
            {
                Energy -= 20;
                Console.WriteLine($"Робот работает...\nИмя: {Name}, энергия: {Energy}\n");
            } else
            {
                Energy -= 0;
                Console.WriteLine("Недостаточно энергии! Робот не может работать :(");
                Console.WriteLine($"Робот: {Name}, энергия: {Energy}\n");
            }
        }
        public void Reload()
        {
            Energy += 50;
            if (Energy > 100)
            {
                Energy = 100;
            }
            Console.WriteLine($"Робот заряжается...\nИмя: {Name}, энергия: {Energy}\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot[] rob = { new Robot("Валера", 90) };
            foreach (Robot r in rob)
            {  
                r.Work();
                r.Work(); 
                r.Reload();
                r.Work();
            }
        }
    }
}
