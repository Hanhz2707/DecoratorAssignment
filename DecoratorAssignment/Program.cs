namespace DecoratorAssignment
{
    using System;
    using System.Runtime.Intrinsics.Arm;

    public interface  Beverage
    {
        public string GetDescription();

        public decimal Cost();
    }

    public class Espresso : Beverage
    {
        public string Description { get; set; } = "Espresso";
        public decimal Price { get; set; } = 1.99M;

        public string GetDescription()
        {
            return Description;
        }

        public decimal Cost()
        {
            return Price;
        }
    }

    public class HouseBlend : Beverage
    {
        public string Description { get; set; } = "House Blend Coffee";
        public decimal Price { get; set; } = 0.89M;

        public string GetDescription()
        {
            return Description;
        }

        public decimal Cost()
        {
            return Price;
        }
    }
    public class DarkRoast : Beverage
    {
        public string Description { get; set; } = "Dark Roast Coffee";
        public decimal Price { get; set; } = 0.99M;

        public string GetDescription()
        {
            return Description;
        }

        public decimal Cost()
        {
            return Price;
        }
    }
    public class Decaf : Beverage
    {
        public string Description { get; set; } = "Decaf Coffee";
        public decimal Price { get; set; } = 1.05M;

        public string GetDescription()
        {
            return Description;
        }

        public decimal Cost()
        {
            return Price;
        }
    }



    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage { get; set; } = default(Beverage)!;

        public abstract string GetDescription();

        public abstract decimal Cost();


    }

    public class Mocha : CondimentDecorator
    {
        public string Description { get; set; } = ", Mocha";
        public decimal Price { get; set; } = 0.20M;

        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + Description;
        }

        public override decimal Cost()
        {
            return Beverage.Cost() + Price;
        }
    }
    public class Soy : CondimentDecorator
    {
        public string Description { get; set; } = ", Soy";
        public decimal Price { get; set; } = 0.15M;

        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + Description;
        }

        public override decimal Cost()
        {
            return Beverage.Cost() + Price;
        }

    }

    public class SteamedMilk : CondimentDecorator
    {
        public string Description { get; set; } = ", Milk";
        public decimal Price { get; set; } = 0.10M;

        public SteamedMilk(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + Description;
        }

        public override decimal Cost()
        {
            return Beverage.Cost() + Price;
        }
    }

    public class Whip : CondimentDecorator
    {
        public string Description { get; set; } = ", Whip";
        public decimal Price { get; set; } = 0.10M;

        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + Description;
        }

        public override decimal Cost()
        {
            return Beverage.Cost() + Price;
        }
    }
    class StarbuzzCoffee
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + "- Cost: $" + beverage.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + "- Cost: $" + beverage2.Cost());


        }
    }



    // Instructions
    // You can implement your whole solution here
    // Optionally you can use folder structure if you deem it necessary
    // For this Assignment we will use Decorator pattern example introduced in the book Head First Design Patterns by O'Reilly
    // Chapeter 3 the DecoratorPattern: Decorating Objects (starts at page 79)
    // Link to pdf: https://github.com/ajitpal/BookBank/blob/master/%5BO%60Reilly.%20Head%20First%5D%20-%20Head%20First%20Design%20Patterns%20-%20%5BFreeman%5D.pdf
    // NOTE: Remember that the code examples in this book are written in java so you can't just copy the code examples given there

}