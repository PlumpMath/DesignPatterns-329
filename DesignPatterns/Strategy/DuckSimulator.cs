using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Observer;
using DesignPatterns.Singleton;
using DesignPatterns.Factory;
using DesignPatterns.State;
using DesignPatterns.Iterator;

namespace DesignPatterns.Strategy
{
    public class DuckSimulator
    {   
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\n\r===========Working with Strategy Pattern=======");

            RedHeadDuck redHeadDuck = new RedHeadDuck();
            redHeadDuck.PerformFly();
            redHeadDuck.PerformQuack();
            redHeadDuck.Swim();
            redHeadDuck.Display();
            Console.WriteLine("\n\rSetting the Behaviour for Ducks that exibit different Behaviours");

            RubberDuck rubberDuck = new RubberDuck();
            rubberDuck.PerformFly();
            rubberDuck.SetFlyBehaviour(new FlyWithRockets());
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();


            Console.WriteLine("\n\n\r===========Working with Observer Pattern=======");

            WeatherData WeatherData = new WeatherData();           

            ForecastDisplay forcastDisplay = new ForecastDisplay(WeatherData);
            WeatherData.WeatherMeasurements(15, 20, 25);

            Console.WriteLine("\n\n\r===========Working with Classic Singleton=======");
            ClassicSingleton classicSingleton = ClassicSingleton.GetInstance();
            classicSingleton.Description();

            Console.WriteLine("\n\n\r===========Working with Static Singleton=======");
            StaticSingleton staticSingleton = StaticSingleton.GetInstance();
            staticSingleton.Description();

            Console.WriteLine("\n\n\r===========Working with Singleton using syncronization=======");
            SingletonUsingSyncronization syncronizedSingleton = SingletonUsingSyncronization.GetInstance();
            syncronizedSingleton.Description();


            Console.WriteLine("\n\n\r===========Working with Factory Design Pattern=======");
            SimplePizzaFactory factory = new SimplePizzaFactory();

            PizzaStore store = new PizzaStore(factory);
            Pizza pizza =  store.OrderPizza("Cheese");
            Console.WriteLine(pizza.ToString());

            Console.WriteLine("\nState Machine Design Pattern");

            GumballMachine machine = new GumballMachine(5);
            Console.WriteLine(machine);

            machine.InsertQuarter();
            machine.EjectQuarter();
            machine.TurnCrank();
            Console.WriteLine(machine);

            Console.WriteLine("\n Working with Iterators");
            DinnerMenu dinnerMenu = new DinnerMenu();
            DesignPatterns.Iterator.Iterator iterator = dinnerMenu.CreateIterator();

            while(iterator.HasNext())
            {
                var current = iterator.Next();
                Console.WriteLine(current);
            }

            Console.WriteLine("\n============================");
            PanCakeHouseMenu panMenu = new PanCakeHouseMenu();
            DesignPatterns.Iterator.Iterator panIterator = panMenu.CreateIterator();

            while (panIterator.HasNext())
            {
                var current = panIterator.Next();
                Console.WriteLine(current);
            }
        }
    }
}
