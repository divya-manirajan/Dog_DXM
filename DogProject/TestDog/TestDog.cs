/**
 * This class tests out each method of the dog class
 * @author Divya Manirajan
 * @version 1.0
 * Proj1-TestDog
 * Sp2020
 */
using System;

namespace TestDog
{
    class TestDog
    {
        public static void Main(string[] args)
        {
            //instantiates dog object with a set age and name
            Dog Charlie = new Dog(11, "Charlie");
            //instantiates dog object with no set age or name
            Dog Avery = new Dog();

            //instantiates dog object that user will enter information for
            Dog User = new Dog();
 
            //prints out Charlie's information, age and name
            Console.WriteLine("Dog object one is "+Charlie.getAge()+" years old.");
            Console.WriteLine("Dog object one is named "+Charlie.getName());

            //prints out Avery's information, age and name
            Console.WriteLine("Dog object two is "+Avery.getAge()+" years old.");
            Console.WriteLine("Dog object two is named "+Avery.getName());

            //sets Avery's age to 12 and name to Avery
            Avery.setAge(12);
            Avery.setName("Avery");

            //prints out Avery's new information, age and name
            Console.WriteLine("Dog object two is " + Avery.getAge() + " years old.");
            Console.WriteLine("Dog object two is named " + Avery.getName());

            //prints out all information for both dog objects, Charlie and Avery
            Console.WriteLine(Charlie.toString());
            Console.WriteLine(Avery.toString());

            //calculates age in dog years for all dog objects
            //and prints these values to the screen
            Console.WriteLine("Charlie is " + Charlie.calcDogYears() + " in dog years");
            Console.WriteLine("Avery is " + Avery.calcDogYears() + " in dog years");

            //reads name from user for dog object
            Console.WriteLine("What would you like to name your dog?");
            string name = Console.ReadLine();

            //reads age from user for dog object
            Console.WriteLine("How old is your dog?");
            int age = Convert.ToInt32(Console.ReadLine());

            //sets input values to dog's name and age
            User.setAge(age);
            User.setName(name);

            //prints out all information for the user inputed dog object
            Console.WriteLine(User.toString());

            //Calculates age in dog years for the user inputed object
            //and prints these values to the screen
            Console.WriteLine("Your dog is "+User.calcDogYears()+" years in dog years");

        }//end Main
    }//end TestDog
}//end namespace
