using System;
using System.Collections.Generic;
using System.Text;

namespace StaticTasks
{
    class Student
    {
        private static  string _fullname;
        private static  string _groupNo;
        public int Age;


        public  Student(int age)
        {
            Console.WriteLine("User Created!");
            Age = age;
        }

        public static string GroupNo
        {
            
            get 
            { 
                return _groupNo;
            }


            set
            {
                while (!CheckGroupNo(value))
                {
                    Console.WriteLine("Group Nomrenizi Duzgun Daxil Edin");
                    value = Console.ReadLine();
                }
                _groupNo = value;
            }
        }
        public static string FullName
        { get
            {
                return _fullname;
            }


          set 
            {
                while (!CheckFullName(value))
                {
                    Console.WriteLine("Fullname-i Duzgun Daxil Edin");
                    value=Console.ReadLine();   
                }
                _fullname= value;
            } 
        } 
        public static bool CheckGroupNo(string groupno)
        {
            int count = 0;
            if (groupno.Length == 4)
            {
                for (int i = 0; i < groupno.Length; i++)
                {

                    if ((char.IsUpper(groupno[i])) && i == 0)
                    {
                        count++;
                       
                    }
                    else if (char.IsDigit(groupno[i]))
                    {
                        count++;
                    }

                }
                
            }
            return count == 4 ? true : false;






        }
        public static bool CheckFullName(string fullname)
        {
            int count = 0;
            for (int i = 0; i < fullname.Length; i++)
            {
                if ((char.IsUpper(fullname[i])) && i == 0)
                {
                    count++;
                }
                else if (char.IsWhiteSpace(fullname[i]))
                {
                    count++;
                    if (char.IsUpper(fullname[i + 1]))
                    {
                        count++;

                    }
                }
            }
            return count == 3 ? true : false;

        }
    }
}
