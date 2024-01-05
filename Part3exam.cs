using System;
using System.Collections.Generic;

public class Part3exam {

    public void DemonstrateCollections()
    {
        List<int> numbers = new List<int> {1, 2, 3};
        Dictionary<string, int> ages = new Dictionary<string, int>
        {
            ["Alice"] = 25,
            ["Bob"] = 30
        };

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine($"Alice's age is {ages["Alice"]}");
    }

    public void DemonstrateArrays()
    {
        int[] array = new int[5];
        array[0] = 1;
        array[1] = 2;

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    public void DemonstrateIndexers()
    {
        SampleCollection<string> stringCollection = new SampleCollection<string>();
        stringCollection[0] = "Hello";
        Console.WriteLine(stringCollection[0]);
    }

    public void DemonstrateReification()
    {
        PrintType(123);
        PrintType("hello");
    }

    public void DemonstrateCovariance()
    {
        List<Animal> animals = new List<Animal>();
        AddAnimals(animals);
    }

    public class SampleCollection<T>
    {
        private T[] arr = new T[100];
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

    public void PrintType<T>(T item)
    {
        Console.WriteLine($"Type of item: {typeof(T)}");
    }

    public class Animal { }
    public class Dog : Animal { }

    public void AddAnimals(IList<Animal> animals)
    {
        animals.Add(new Animal());
        animals.Add(new Dog());
    }
}
