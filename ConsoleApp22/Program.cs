using System;
using System.Collections.Generic;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Product
    {
        public int _Price { get; private set; }
        public Name_product _Name { get; private set; }
        public Product(int Price, Name_product Name)
        {
            _Price = Price;
            _Name = Name;
        }
    }

    public class Shop
    {
        private List<Product> _product;
        public Shop(List<Product> product)
        {
            _product = product;
        }
        public void Add_Product(Product product)
        {
            _product.Add(product);
        }
        public void Remuve_Product(Product product)
        {
            _product.Remove(product);
        }
        public bool Check_Product(Name_product PRODUCT, out Product product)
        {
            bool result = false;
            product = null;
            foreach (var item in _product)
            {
                if (item._Name == PRODUCT)
                {
                    product = item;
                    result = true;
                    return result;
                }
                return result;
            }
            return result;
        }

        public void Buy_Product(Name_product PRODUCT, Pay cash)
        {
            if (Check_Product(PRODUCT, out Product product))
            {
                cash.Remuve_many(product._Price);
                Remuve_Product(product);
            }
        }
    }

    public class Pay
    {
        private float _Many;
        public Pay(float Many)
        {
            _Many = Many;
        }
        public void Remuve_many(int a)
        {

            if ((_Many - a) <= 0)
            {
                Console.WriteLine(_Many);
            }
            else
            {
                _Many -= a;
            }
        }
    }

    public class Cash : Pay
    {
        public Cash(float Many) : base(Many)
        {

        }
    }

    public class Non_Cash : Pay
    {
        public Non_Cash(float Many) : base(Many)
        {

        }
    }
}

public enum Name_product
{
    potato,
    chicken,
    bell_pepper,
    milck,
    bannan
}