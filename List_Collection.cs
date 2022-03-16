
using System.Runtime.CompilerServices;
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information

// A list data structure representing a collection of element  of the same type

// List<int> List = new List<int>() { 1, 2, 3, 4, 5, 8, 10, 24 };
// List<int> List01 = new List<int>(8) ;

// System.Console.WriteLine("Input data list");

// // INPUT ELEMENT
// for(var i =0; i < 5; i++) {
//     System.Console.Write("Element With Index: " + i + ":");
//     List01.Add(Convert.ToInt32(Console.ReadLine()));
// }

// System.Console.WriteLine();

// System.Console.WriteLine("Output data list");


// // OUTPUT ELEMENT
// for(var i =0; i< 8;i++ ) {
//  System.Console.Write("Element with Index: " + i + ":");
//  System.Console.WriteLine(List01[i]);
// }


// //!COUNT 

// // Count elememt
// System.Console.WriteLine("Count: " + List01.Count);



// //! METHOD

// //! ADD

// // Add element
// List01.Add(5); 

// // Can add array to a list
// List01.AddRange(new int[] {3,4,5});


// //! INSERT

// // Insert element    Syntax:  <name list> . Insert( <position> , <value> )
// List01.Insert(0, 11);

// // Insert a group element into list
// List01.InsertRange(0, new int[] {3,4,5});


// //! REMOVE

// // remove element with index  Syntax: <name_list> . RemoveAt (<index_remove>)
// List01.RemoveAt(5);

// // remove element with value  Syntax: <name_list>.Remove (<value>)
// // remove only delete element first see
// List01.Remove(3);

// // remove all

// List01.RemoveAll();
// //or
// List01.Clear();

// foreach(var value in List01) {
//     System.Console.WriteLine("Value element in List : " +value);
// }


// //! SEARCH ELEMENT


// // Find search element first satisfy the condition
// var n = List.Find((n) => n % 2 == 0);
// System.Console.WriteLine(n);

// // FindAll return all element satisfy condition

// var k = List.FindAll((n)=> n%2 ==0);
// foreach (var item in k)
// {
//     System.Console.WriteLine("Value: "+ item);
// }

// List<MyProduct.MyProduct> products = new List<MyProduct.MyProduct>() {
//     new MyProduct.MyProduct() {
//         NameProduct ="Iphone 1", PriceProduct= 200, ID = 1, Origin = "China"
//     },
//     new MyProduct.MyProduct() {
//         NameProduct ="Iphone 2", PriceProduct= 700, ID = 2, Origin = "Korea"
//     },
//     new MyProduct.MyProduct() {
//         NameProduct ="Iphone 3", PriceProduct= 400, ID = 3, Origin = "Spain"
//     },
//     new MyProduct.MyProduct() {
//         NameProduct ="Iphone 4", PriceProduct= 100, ID = 4, Origin = "USA"
//     },
// };

// //Find
// var CorrectProduct = products.Find((p) =>
// {
//     return p.Origin == "USA";
// });
// if (CorrectProduct != null)
// {
//     System.Console.WriteLine($"{CorrectProduct.ID }-{CorrectProduct.NameProduct}-{CorrectProduct.PriceProduct}-{CorrectProduct.Origin}");
// };

// //Find All
// var StartProduct = products.FindAll((p)=>p.NameProduct.StartsWith("I"));
// foreach (var item in StartProduct)
// {
//     System.Console.WriteLine(item.NameProduct );
// }


//! SORTED_LIST  syntax: SortedLList<type_key, type_elemnt> = new...

// Sorted_list = 2 list = 1 list key + 1 list value
SortedList< string , MyProduct.MyProduct> products = new SortedList<string, MyProduct.MyProduct> ();

// Add sortedList
products["products1"] = new MyProduct.MyProduct() {  NameProduct ="Iphone 1", PriceProduct= 200, Origin = "China"};
products["products2"] = new MyProduct.MyProduct() {  NameProduct ="SamSung", PriceProduct= 400, Origin = "Korea"};
products["products3"] = new MyProduct.MyProduct() {  NameProduct ="Nokia", PriceProduct= 100, Origin = "Japan"};


products.Add("products",  new MyProduct.MyProduct() {  NameProduct ="Iphone 4", PriceProduct= 200, Origin = "China"});

//INPUT SortedList
// SortedList< string , MyProduct.MyProduct> products1 = new SortedList<string, MyProduct.MyProduct> (5);
// for(var i=0; i<5 ;i++) {
//     System.Console.WriteLine("Input Product:");
//     products.Add(Console.ReadLine(),  new MyProduct.MyProduct() {  NameProduct =Console.ReadLine(), PriceProduct= Convert.ToDouble(Console.ReadLine()), Origin =Console.ReadLine()});
// }


// var p= products["products"];
// System.Console.WriteLine(p.NameProduct);

// make list key and list values

var keys = products.Keys;
var values = products.Values;

// output

foreach (var k in keys)
{
    var product = products[k];
    System.Console.WriteLine(product.NameProduct);
}

//! Important

// Interate over each element
foreach (KeyValuePair<string, MyProduct.MyProduct>  item in products) {
    var keys1 = item.Key;
    var values1 = item.Value;
    System.Console.WriteLine($"{keys1}---{values1.NameProduct}");
}


//! Remove

// remove element with keys
products.Remove("products1");

// remove element with index
products.RemoveAt(0);

// remove all
products.Clear();


foreach (KeyValuePair<string, MyProduct.MyProduct>  item in products) {
    var keys1 = item.Key;
    var values1 = item.Value;
    System.Console.WriteLine($"{keys1}---{values1.NameProduct}");
}


























