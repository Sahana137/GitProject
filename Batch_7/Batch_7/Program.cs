using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Batch_7.Program;

namespace Batch_7
{
     public interface AnimalInter
    {
        int Run();
    }
    public  abstract class AnimalAbstraction
    {
        public abstract void Roar();

        public abstract string Eat(string food1, string food2);

        public void Sleep(int time)
            {
                time = 5;
                Console.WriteLine($"{time}hr");
            }
        public void Sleep()
        {
           
            Console.WriteLine($"sleep");
        }
    }
    public class Tiger : AnimalAbstraction, AnimalInter
    {

        int legs;
        string colour;
        int eye;

        public Tiger()
        {
            legs = 4;
            Console.WriteLine($"tiger has {legs} legs ");
        }
        public Tiger(string colour, int eye)
        {
            this.colour = colour;
            this.eye = eye;
            Console.WriteLine($"tiger colour is {colour},and has {eye} eyes");
        }

        public override void Roar()
        {
            Console.WriteLine("Tiger is roaring!");
        }
        public override string Eat(string food1, string food2)
        {
            Console.WriteLine($"Tiger prefers {food1} over {food2}");
            return food1;
        }
        public int Run()
        {
            return 10;
        }
    }
   
    class Program
        {
        public static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            Tiger tiger1 = new Tiger("yellow", 2);
            tiger.Run();
            tiger.Roar();
            tiger.Eat("Deer","Zebra");
            tiger.Sleep(5);
            tiger.Sleep();
        }
    }
 }

