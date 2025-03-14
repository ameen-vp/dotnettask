// See https://aka.ms/new-console-template for more information
using System;
using static Animal;
public class Animal
{
    public String Name { get; set; }
    public int Age { get; set; }
   

    public Animal(string name, int age) {
        Name = name;
        Age = age;

    }
    public void Speak()
    {
        Console.WriteLine($"The enimal name : {Name},This is animal age : {Age}");
    }
    public class Dog : Animal
    {
        public string Bread { get; set; }
        public Dog(string bread, int age, string name) : base(name, age)
        {
            Bread = bread;
        }
        public void Americanbreas()
        {
            Console.WriteLine($"This is bread {Bread},bread is age {Age},bread is name {Name}");
        }
    }

    public class Cat : Animal
    {
            public  Cat (string name, int age) : base(name,age)
            { }

            public void  meow()
            {
                Console.WriteLine("meow");
            }

    }



}
    public class Program {
        public static void Main()
        {
            Animal.Dog ameen= new Animal.Dog("Bread", 3, "Goldenrivever");
            Animal.Cat = new Animal.Cat ("cat",2,);
            
            ameen.Speak();
        ameen.Americanbreas();
        }
       
              }

    
