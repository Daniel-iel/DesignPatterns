using System;

namespace _1_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IElement[] elements =
            {
                new Book(20, "1234"),
                new Fruit(10,1,"Banana")
            };

            IShoppingCartVisitor shoppingCartVisitor1 = new ShoppingCartVisitor1();
            IShoppingCartVisitor shoppingCartVisitor2 = new ShoppingCartVisitor2();

            int sum = 0;
            foreach (var element in elements)
            {
                if (element is Book)
                {
                    sum += element.Accept(shoppingCartVisitor1);
                }
                else
                {
                    sum += element.Accept(shoppingCartVisitor2);
                }
            }
        }
    }

    internal interface IElement
    {
        int Accept(IShoppingCartVisitor visitor);
    }

    internal interface IShoppingCartVisitor
    {
        int Visit(Book book);
        int Visit(Fruit fruit);
    }

    internal class Fruit : IElement
    {
        private readonly int priceKg;
        private readonly int weight;
        private readonly string name;

        public Fruit(int priceKg, int wt, string nm)
        {
            this.priceKg = priceKg;
            this.weight = wt;
            this.name = nm;
        }

        public int GetPriceKg()
        {
            return this.priceKg;
        }

        public int GetWight()
        {
            return this.weight;
        }

        public string GetName()
        {
            return this.name;
        }

        public int Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    internal class Book : IElement
    {
        private readonly int price;
        private readonly string isBnNumber;

        public Book(int cost, string isBn)
        {
            this.price = cost;
            this.isBnNumber = isBn;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public string GetIsBnNumber()
        {
            return this.isBnNumber;
        }

        public int Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    internal class ShoppingCartVisitor1 : IShoppingCartVisitor
    {
        public int Visit(Book book)
        {
            int cost = 0;

            if (book.GetPrice() > 50)
            {
                cost = book.GetPrice() - 5;
            }
            else
            {
                cost = book.GetPrice();
            }

            Console.WriteLine($"Book ISBN:: {book.GetIsBnNumber() } cost = {cost}");

            return cost;
        }

        public int Visit(Fruit fruit)
        {
            int cost = fruit.GetPriceKg() * fruit.GetWight();
            Console.WriteLine($"{fruit.GetName()} Cost = {cost}");

            return cost;
        }
    }

    internal class ShoppingCartVisitor2 : IShoppingCartVisitor
    {
        public int Visit(Book book)
        {
            int cost = book.GetPrice(); ;

            Console.WriteLine($"Book ISBN:: {book.GetIsBnNumber() } cost = {cost}");

            return cost;
        }

        public int Visit(Fruit fruit)
        {
            int cost = fruit.GetPriceKg() * fruit.GetWight() - ((fruit.GetPriceKg() * 10) / 100);
            Console.WriteLine($"{fruit.GetName()} Cost = {cost}");

            return cost;
        }
    }
}
