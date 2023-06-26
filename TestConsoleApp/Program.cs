// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

//Console.WriteLine("Hello, World!");
ClassD objD=new ClassD("I am D");
DerivedClass DC = new DerivedClass();
((BaseClass)DC).Method();
//DC.Method();

TestStruct T = new TestStruct(100);

Console.WriteLine(T.MyProperty);

