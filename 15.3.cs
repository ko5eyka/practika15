using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._3
{
    interface Price
    {
        void GetPrice();
    }
    interface Warranty
    {
        void GetWarranty();
    }
    class Phone : Price, Warranty
    {
        private int price;
        private int warranty;
        public int Price
        {
            get { return price; }
            set
            {
                if (value >= 0) { price = value; }
                else
                {
                    Console.WriteLine("Цена не может быть отрицательна!");
                }
            }
        }
        public int Warranty
        {
            get { return warranty; }
            set
            {
                if (value > 0) { warranty = value; }
                else
                {
                    warranty = 0;
                }
            }
        }
        public void GetPrice()
        {
            Console.WriteLine($"Цена телефона: {Price} руб");
        }
        public void GetWarranty()
        {
            if (Warranty > 0)
            {
                Console.WriteLine($"Гарантия: {Warranty} мес");
            }
            else
            {
                Console.WriteLine($"Гарантия: отсутствует");
            }
        }
        public Phone(int price, int warranty)
        {
            Price = price;
            Warranty = warranty;
        }
        public Phone(int price)
        {
            Price = price;
            Warranty = 0;
        }
    }
    class Laptop: Price
    {
        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (value >= 0) { price = value; }
                else
                {
                    Console.WriteLine("Цена не может быть отрицательна!");
                }
            }
        }
        public Laptop(int price)
        {
            Price = price;
        }
        public void GetPrice()
        {
            Console.WriteLine($"Цена ноутбука: {Price}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;
            Phone[] phones = { new Phone(15000) };
            foreach (Phone p in phones)
            {
                p.GetPrice();
                p.GetWarranty();
                Count += p.Price;
            }

            Console.WriteLine();

            Laptop[] lap = { new Laptop(25000) };
            foreach (Laptop l  in lap)
            {
                l.GetPrice();
                Count += l.Price;
            }

            Console.WriteLine();

            Console.WriteLine($"Общая стоимость: {Count} руб.");
        }
    }
}
