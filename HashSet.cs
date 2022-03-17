// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// collection list don't allow  duplicate values

HashSet<int> Set1 = new HashSet<int>() {1,2,3,4,5};
HashSet<int> Set2 = new HashSet<int>() {1,7,5,6,3,2,6};


Set1.Add(12);
Set1.Remove(2);


// UnionWith return set 1
Set1.UnionWith(Set2);

foreach(var item in Set1) {
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-----------------");
Set1.IntersectWith(Set2);
foreach (var item in Set1)
{
    System.Console.WriteLine(item);
}
