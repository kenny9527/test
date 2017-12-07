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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="anl"></param>
        /// <param name="food"></param>
        /// <param name="eatKG"></param>
        static void Eat( Animal anl , string food  ) {
            double eatKG = anl.getWeight_KG();
            Console.WriteLine("吃"+food+" 原始體重"+ eatKG + "公斤");

            
            for (int n = 0 ; n < eatKG ; n++) {
                anl.Eat(food);
            }
        }
    }
}
