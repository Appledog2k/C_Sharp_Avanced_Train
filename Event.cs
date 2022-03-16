// See https://aka.ms/new-console-template for more information
/*

   class event : publisher => class => genator event

   class receiver : subscriber => class => receiver event
   
*/



Console.WriteLine("Hello, World!");

// publishser
Event.UserInput userInput01 = new Event.UserInput();


// subscriber 00
Event.Square square = new Event.Square();
square.Subs(userInput01);


// subscriber 01 ~ delete sub00
Event.Square01 square01 =new Event.Square01();
square01.Subs(userInput01);

userInput01.Input();



