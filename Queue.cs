// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Queue<string> Profiles =new Queue<string> ();
Profiles.Enqueue("Profiles 1");

Profiles.Enqueue("Profiles 2");

Profiles.Enqueue("Profiles 3");

// Interate all element
foreach (var item in Profiles)
{
    System.Console.WriteLine($"ProFiles: {item}");
}

System.Console.WriteLine("-------------------");

//read element head queue
var x = Profiles.Peek();
System.Console.WriteLine("Element Head Queue: "+ x);



// first in / first out
var ProcessFiles = Profiles.Dequeue();
System.Console.WriteLine($"The files has been process: {ProcessFiles}---- number of records remaining: {Profiles.Count()}");

