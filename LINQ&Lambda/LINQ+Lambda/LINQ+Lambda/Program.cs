using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LINQ_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringArray();
            QueryIntArray();
            QueryArray();
            
            

            Console.ReadLine();
        }

        static void QueryStringArray()
        {
            string[] dog = { "Pucho", "K 9", "Roberto Carlos", "Milanesa", "Acoyte y Rivadavia", "Snoopy" };

            var dogSpaces = dog.Where(d => d.Contains(" "))
                            .OrderByDescending(d => d)
                            .ToList();

            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }

        }

        static int[] QueryIntArray()
        {
            int[] nums = { 1, 2, 11, 88, 100, 25, 13 };

            var numGreaterthan20 = nums.Where(n => n > 20)
                                        .OrderBy(n => n)
                                        .ToArray();

            foreach (var n in numGreaterthan20)
            {
                Console.WriteLine(n);
            }

            return numGreaterthan20;
        }

        static void QueryArray()
        {
            ArrayList animals = new ArrayList()
            {
                new Entities.Animal
                {
                    Name ="Pucho",
                    Height=35,
                    Weight=5
                },
                new Entities.Animal
                {
                    Name = "Elvira",
                    Height = 15,
                    Weight = 4
                },
                new Entities.Animal
                {
                    Name="Godzilla",
                    Height=1020,
                    Weight=5000,
                }
            };

            var animalsEnum = animals.OfType<Entities.Animal>();

            var smAnimals = animalsEnum.Where(a => a.Weight < 50)
                                        .ToList();

            foreach (var a in smAnimals)
            {
                Console.WriteLine(a);
            }
        }

    }
}
