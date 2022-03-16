using System;
// See https://aka.ms/new-console-template for more information
/*
 Lambda - Anonymous Func

1)
(int a, int b) => expression

2)
(parameter) => {
    expression;
    return return_expression;
}
*/

//create delegate
Action<string> Notice01;
// create expression lambda
Notice01 = (string s) => System.Console.WriteLine(s); // ~delegate void Name(string s) =Action<string>
Notice01?.Invoke("Hello");


// (int a, int b) =>
// {
//     int results = a + b;
//     return results;
// };


//using expression lambda in library .NET
int[] Arr = { 1, 2, 5, 3, 2, 5, 6 };
var results01 = Arr.Select((int x) => Math.Sqrt(x));
foreach (var value in results01)
{
    System.Console.WriteLine(value);
};

Arr.ToList().ForEach(
    (int x) =>
    {
        if (x % 2 != 0)
        {
            System.Console.WriteLine(x);

        }
    }
);


var results02 = Arr.Where((x)=> x >= 3 && x <= 50);
foreach (var n in results02)
{
    System.Console.WriteLine(n);
};



