﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ConsoleApp3
    {
        static void Main(string[] args)
        {
            car car = new car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());


            List<int> list = new List<int>() { 101, 274, 31, 42 };
            list.RemoveAt(0);

            foreach (int i in list)
            {
                Console.WriteLine("count : " + list.Count + "\t" + i);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(-52.273));
            Console.WriteLine(Math.Floor(-52.273));
            Console.WriteLine(Math.Round(-52.273));
            Console.WriteLine(Math.Max(312, 123));
            Console.WriteLine(Math.Min(312, 123));
            Console.WriteLine(Math.PI);

            //Product product = new Product();
            //product.name = "고구마";
            //product.price = 6000;

            Product productA = new Product() { name = "감자", price = 2000};
            //Console.WriteLine(product);

            List<Student> a = new List<Student>()
            {
                new Student() { name = "박수연", grade = 1 },
                new Student() { name = "박수", grade = 10 },
                new Student() { name = "박", grade = 100 },
                new Student() { name = "박수", grade = 10 },
                new Student() { name = "박수연", grade = 1 },
            };
            a.Add(new Student() { name = "박수연", grade = 100 });
            a.Add(new Student() { name = "박수연", grade = 10 });
            a.Add(new Student() { name = "박수연", grade = 90 });
            a.Add(new Student() { name = "박수연", grade = 30 });
            a.Add(new Student() { name = "박수연", grade = 120 });

            //foreach (var student in a)
            //{
            //    if (student.grade > 20)
            //    {
            //        a.Remove(student);
            //    }
            //}
            //for(int i = 0; i<a.Count; i++)
            //{
            //    if (a[i].grade > 20)
            //    {
            //        a.Remove(a[i]);
            //        i--;
            //    }
                    
            //}
            for (int i = a.Count-1; i >=0; i--)
            {
                if (a[i].grade > 20)
                {
                    a.Remove(a[i]);
                }

            }

            foreach (var student in a)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine(myMath.Abs(52));

        }
    }
}
