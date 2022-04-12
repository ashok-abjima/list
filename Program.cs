using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsList
{
    internal class Program
    {
       /* static void Main(string[] args)
        {
            List<string> li = new List<string>();
            //li.Capacity = li.Count +2;
            li.Add("Ram");
            li.Add("Shyam");
            li.Add("Radhe");
            li.Add("Bhola");
            li.Add("JGD");

            var data = new string[] { "Raj", "Vick", "John", "Remo", "Suraj" };
            li.AddRange(data);
            li.Insert(3, "Ashok");
            //li.First();


            //Console.WriteLine(li[1]);
            //li.RemoveAt(2);

            li.RemoveRange(1, 2);
            foreach (string item in li)
            {
                Console.WriteLine(item);
            }
    Console.WriteLine("Item Count :{0}",li.Count);
            Console.ReadKey();
        }*/



        static void Main(String[] args)
        {


            List<int> lis = new List<int>();
            lis.Add(1);
            lis.Add(2);
            lis.Add(lis[1]+3);

            lis.Add(4);


           
            Console.WriteLine("Max Value :{0}",lis.Max());
            
            Console.WriteLine("Unique Value :{0}",lis.Distinct());


            foreach (int item in lis)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Item Count :{0}", lis.Count);
            Console.ReadKey();
        }


            


        
    }
}
