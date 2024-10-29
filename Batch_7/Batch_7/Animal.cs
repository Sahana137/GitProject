using Batch_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class Animal
    {
        int legs;
        string colour;
        int eye;

        public Animal()
        {
            legs = 4;
            Console.WriteLine($"tiger has {legs} legs ");
        }
        public Animal(string colour, int eye)
        {
            this.colour = colour;
            this.eye = eye;
            Console.WriteLine($"tiger colour is{colour},and has {eye} eyes");
        }
        public void Roar()
        {
            Console.WriteLine("roaring");
        }
        public string Eat(string food1,string food2)
        {
            food1 = "deer";
            return food1;
        }
        public int Run()
        {
            return 10;
        }
        public void sleep(int time)
        {
            time = 5;
            Console.WriteLine($"{time}hr");
        }
        public static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal animal1 = new Animal("yellow", 2);
            //Animal animal3 = new Animal();
            animal.Roar();
            string food=animal.Eat("deer", "zebra");
            Console.WriteLine(food);
            int running=animal.Run();
            Console.WriteLine(running);
            animal.sleep(5);
        }
    }
}

//Animal animal = new Animal();
//Animal animal1 = new Animal("yellow", 2);
////Animal animal3 = new Animal();
//animal.Roar();
//string food = animal.Eat("deer", "zebra");
//Console.WriteLine(food);
//int running = animal.Run();
//Console.WriteLine(running);
//animal.sleep(5);