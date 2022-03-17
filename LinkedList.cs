// See https://aka.ms/new-console-template for more information
/*
    LinkedList :   -------0-----0------0-------
    Node       :        0
    Syntax:
    LinkedList <type_data_node> name= new .....

*/

LinkedList<string> Courses = new LinkedList<string>();

// Add first Linkedlist
var course1 = Courses.AddFirst("course 1");

// Add last Linkedlist
var course3 = Courses.AddLast("course 3");

// insert after node
// declace data node
LinkedListNode<string> course2 = Courses.AddAfter(course1, "course 2");

var course4 = Courses.AddLast("course 4");
var course5 = Courses.AddLast("course 5");


//interate
foreach (var item in Courses)
{
    System.Console.WriteLine($"course: {item}");
}
System.Console.WriteLine("---------------");
// node value
var node = course2;
System.Console.WriteLine(node.Value);

// node previous
node = node.Previous;
System.Console.WriteLine(node.Value);


// node next
node=node.Next.Next;
System.Console.WriteLine(node.Value);

System.Console.WriteLine("-------------");


// interate
var node1 = Courses.Last;
while(node1 != null) {
System.Console.WriteLine(node1.Value);
node1 =node1.Previous;
}






