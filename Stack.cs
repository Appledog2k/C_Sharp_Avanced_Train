// See https://aka.ms/new-console-template for more information

// Stack=  last in - first out
Stack<string> Goods = new Stack<string> ();

//Add element head stack
Goods.Push("Goods 1");
Goods.Push("Goods 2");
Goods.Push("Goods 3");

// Count Element in Stack
System.Console.WriteLine("Count Goods: "+ Goods.Count);

// Read element Head Stack

System.Console.WriteLine(Goods.Peek());

// remove element head stack  =  element last in Push
var Goods1 = Goods.Pop();
System.Console.WriteLine($"Loading Goods: {Goods1}");

//Test element in stack return true/false
System.Console.WriteLine(Goods.Contains("Goods 1"));





