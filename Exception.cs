// See https://aka.ms/new-console-template for more information


// Exception = navigating program does not end  abrupt
using Exception01;


int a = 5;
int b = 4;


// test error

try
{
    var c = a / b;
    System.Console.WriteLine(c);

    int[] i = { 1, 2 };
    var x = i[5];




}

// get error
catch (DivideByZeroException e)
{
    // error ?
    System.Console.WriteLine(e.Message);

    // postion error
    // System.Console.WriteLine(e.StackTrace);

    // get error correct
    // System.Console.WriteLine(e.GetType().Name);

    // notice error
    System.Console.WriteLine("End");

}

catch (Exception e1)
{
    System.Console.WriteLine(e1.Message);

}

// continue program


System.Console.WriteLine("End progaming");

try
{
    Exception01.Exception01.Registor("",19);
}
catch (System.Exception e)
{

    System.Console.WriteLine(e.Message);
}
// catch (Exception Name)
// {
//     System.Console.WriteLine(Name.Message);
// }