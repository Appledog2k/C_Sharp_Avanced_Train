using System.Numerics;
// See https://aka.ms/new-console-template for more information
using Static;



CountNumber C1 =new CountNumber();
CountNumber C2= new CountNumber();


C1.Count();
C2.Count();

CountNumber.Info();

Student name01 = new Student("Nguyen Quang Hung");
System.Console.WriteLine(name01.name);

vector vector01 = new vector(2,3);
vector vector02 = new vector(1,1);

var vector =vector01 +vector02;
vector01.Coordinates();
vector02.Coordinates();

vector.Coordinates();


vector vector03 =new vector(4,5);
// ~ vector03[0] => x
// ~ vector03[1] => y
/* Constructor  vector03["toandoX"] ~ x 
                vector04["toadoY"] ~y
*/

vector03[0]=5;
vector03[1]=6;
vector03.Coordinates();




