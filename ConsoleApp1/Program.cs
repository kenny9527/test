using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libray;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal("dog",2300);
            dog.color = "black";
            Program.Eat(dog ,"hot dog"  );


            Console.ReadKey();
        }

        static void Eat( Animal aml , string food  ) {
            double eatKG = aml.weightKG;
            string str = string.Format("吃 {0} 原始體重 {1} 公斤",food, eatKG);
            Console.WriteLine(str);

            
            for (int n = 0 ; n < eatKG ; n++) {
                aml.Eat(food);
            }
        }
    }
}
