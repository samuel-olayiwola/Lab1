using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {   //Lab1
            //question A
            Console.WriteLine("Hello Samuel, I am in the Backend tact of Wella Schools");
            //Questiom B
            Console.WriteLine("I joined this tracct because i believe i am well equipped to succede there.I have a very analytical mind, i love efficiency and implementing new solutions.\nThere is also the reason of making money also");
        
            //lab2

            //declare variables
            int age;
            string name;
            bool isValid;
            short num;
            long number;
            float val;
            byte data;
            char info;
            DateTime date;
            decimal dec;

            //implicit conversion
            val = 5; //val is a float while 5 is an integer. It implicitly converts 5 to a foat
            Console.WriteLine(val);
            age = (int)5.4;//we explicitly typecast 5.4 which is a float to an int.
            Console.WriteLine(age);
            //

           
            
        
        }
    }
}
