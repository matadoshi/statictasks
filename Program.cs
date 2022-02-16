using System;

namespace StaticTasks
{
   class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Console.WriteLine("Fullname Daxil Edin");
            //string name=Console.ReadLine()??"";
            //Student.FullName = name;


            //Console.WriteLine("Group No Daxil Edin");
            //string no=Console.ReadLine()??"";
            //Student.GroupNo = no;

            //Console.WriteLine("Yasinizi Daxil Edin:");
            //int.TryParse(Console.ReadLine(), out int age);
            //Student stu1 = new Student(age);


            //Console.WriteLine($"Fullname:{Student.FullName}\nGroup:{Student.GroupNo}\nAge:{stu1.Age}");
            #endregion
            #region Task2
            Console.Write("Reqem daxil edin hansi ki,cut olub olmadigini yoxlasin:");
            int.TryParse(Console.ReadLine(), out var result);
            Console.WriteLine(ExtentionMethods.IsEven(result));

            Console.WriteLine("Arrayin Uzunlugunu Daxil Edin");
            int.TryParse(Console.ReadLine(), out int size);
            int[] abc = new int[size];
            for (int i = 0; i < abc.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out abc[i]);
            }
            Console.WriteLine("Reqem Daxil Edin");
            int.TryParse(Console.ReadLine(), out int a);



            foreach (var item in ExtentionMethods.GetValueIndex(abc, a))
            {
                Console.Write($"{item} ");
            }
            #endregion
        }
    }
}
