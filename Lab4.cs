using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Lab4
    {
        class bank_account
        {
            public int balance;
            public bool validationCheck(int n)
            {
                if (n > balance)
                {
                    return false;
                }
                else { return true; }
            }
        }
        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public Car(string make, string model, int year)
            {
                Make = make;
                Model = model;
                Year = year;
            }

            public string FullCarName
            {
                get { return $"{Make} {Model} {Year}"; }
            }
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
            public string FullNameInUpperCase
            {
                get { return $"{FirstName} {LastName}".ToUpper(); }
            }
        }
        public class Temperature
        {
            public double Celsius { get; set; }

            public Temperature(double celsius)
            {
                Celsius = celsius;
            }

            public double Fahrenheit
            {
                get { return (Celsius * 9 / 5) + 32; }
            }
        }
        public void Program1()
        {
            bank_account b = new bank_account();
            b.balance = 60000;
            if (b.validationCheck(50000))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void Program2()
        {
            Car myCar = new Car("Toyota", "Camry", 2022);

            Console.WriteLine("Make: " + myCar.Make);
            Console.WriteLine("Model: " + myCar.Model);
            Console.WriteLine("Year: " + myCar.Year);
            Console.WriteLine("Full Car Name: " + myCar.FullCarName);
        }
        public void Program3()
        {
            Person person = new Person("Yashika", "Agrawal");
            Console.WriteLine("Full Name in Uppercase: " + person.FullNameInUpperCase);
        }
        public void Program4()
        {
            Temperature temp = new Temperature(25.0);

            Console.WriteLine("Temperature in Celsius: " + temp.Celsius);
            Console.WriteLine("Temperature in Fahrenheit: " + temp.Fahrenheit);
        }

    }
}
