using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
interface IAnimal
{
    string MakeNoise();
}
public class Cat : IAnimal
{
    public string MakeNoise()
    {
        return "Meow!";
    }
}
public class Dog : IAnimal
{
    public string MakeNoise()
    {
        return "Woof!";
    }
}
class Program
{
    static void Main()
    {
        var cat = new Cat();
        var dog = new Dog();

        Console.WriteLine("Cat goes " + cat.MakeNoise());
        Console.WriteLine("Dog goes " + dog.MakeNoise());
        Console.ReadLine();
    }
}
}
