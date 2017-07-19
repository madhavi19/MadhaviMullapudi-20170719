using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsbcSampleConsoleApp
{
    interface LoggingCred
    {
        void show(string str);
    }
    class LoginDet:LoggingCred
    {
       
        
        public void show(string str)
        {
            if (str == "Admin")
            {
                Console.WriteLine("Hi I am an admin");
            }
            else if(str == "user1")
            {
                Console.WriteLine("Hi I am an user1");
            }
            else if (str == "user2")
            {
                Console.WriteLine("Hi I am an user2");
            }
            else 
            {
                Console.WriteLine("Invalid username");
            }
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username");
            string s1;
            s1 = Console.ReadLine();
            LoginDet ld = new LoginDet();
            ld.show(s1);
            Console.ReadLine();

        }
    }
}
