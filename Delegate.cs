// See https://aka.ms/new-console-template for more information

// Delegate.ShowLog Log = null ;

// // Log= Delegate.Delegate.Info;

// // Log("Hello");

// // // 2 ways test var different null

// // // using if 

// // // using var?.
// // //using method in delegate
// // Log?.Invoke("Hi");

// // Log = Delegate.Delegate.Warning;
// // Log("Học về delegate");
// Log += Delegate.Delegate.Info ;
// Log += Delegate.Delegate.Warning;

// Log?.Invoke("Hi everyone!");



//! Action , Func : delegate -generic

// don't return type
Action action; // ~delegate void _name_return();
Action<string, int> action1; //~delegate void _name_return(string s ,int i);
Action<string> action2;
action2= Delegate.Delegate.Warning;
action2?.Invoke("Action");

// return type

Func<int> F1;  //~ delegate int _name();
Func<string, double, string> F2; //~delegate string _name(string s, double s);

//!
Func<int, int , int> Results;
Results =Delegate.Delegate.Sum;
System.Console.WriteLine(Results(10,20));





