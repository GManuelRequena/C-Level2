using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Challenge:
            Create a console .Net Framework proyect
            Create a new class called Phone
            Add the following attributes:
                Model           string
                Brand           string
                phoneNumber     String
                code(1,2,3)     int
            Add the following properties:
                Model           Read Only
                Brand           Read Only
                PhoneNumber     Read and Write
                Code            Read, Write and check it is between 1 and 3, otherwise 0
            Add a constructor that recives Model and Brand
            Create some objects in main and try adding data and showing it
            Add a method called Call() that returns this string 'Calling...'
            Overload the method to Call(string name) and return this string: 'Calling to + name'
            Try all methods in main
            */

            //Phone 1
            Phone phone1 = new Phone("G200", "Motorla");

            //Phone 2
            Phone phone2 = new Phone("13 Pro Max", "iPhone");

            //Phone 3
            Phone phone3 = new Phone("S23 Ultra", "Samsung");

            Console.WriteLine("Insert phone number of phone1: ");
            phone1.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Insert Code (1, 2, 3): ");
            phone1.Code = int.Parse(Console.ReadLine());
            Console.WriteLine("Phone 1 status: ");
            Console.WriteLine("Phone model: " + phone1.Model);
            Console.WriteLine("Phone brand: " + phone1.Brand);
            Console.WriteLine("Phone number: " + phone1.PhoneNumber);
            Console.WriteLine("Phone code: " + phone1.Code);
            Console.WriteLine(phone1.Call());
            Console.WriteLine(phone1.Call("Manuel"));
            Console.ReadKey();
        }
    }
}
