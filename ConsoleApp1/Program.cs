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
            Animal dog = new Animal("dog",10);
            dog.color = "black";
            Program.Eat(dog ,"hot dog" , 5.5 );


            Console.ReadKey();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="anl"></param>
        /// <param name="food"></param>
        /// <param name="eatKG"></param>
        static void Eat( Animal anl , string food , double eatKG ) {
            Console.WriteLine("吃"+food+" "+eatKG+"公斤");
            int index = 0;
            while ( index<eatKG ) {
                anl.Eat(food);
                index += 1;
            }
        }
    }
}
