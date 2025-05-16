// See https://aka.ms/new-console-template for more information

using btvn;

MyStack<int> intStack = new MyStack<int>();
intStack.Push(10);
intStack.Push(20);
Console.WriteLine("Top of intStack: " + intStack.Peek());
Console.WriteLine("Popped from intStack: " + intStack.Pop());
Console.WriteLine("intStack is empty? " + intStack.IsEmpty());

Console.WriteLine();
MyStack<string> stringStack = new MyStack<string>();
stringStack.Push("Hello");
stringStack.Push("World");
Console.WriteLine("Top of stringStack: " + stringStack.Peek());
Console.WriteLine("Popped from stringStack: " + stringStack.Pop());
Console.WriteLine("stringStack is empty? " + stringStack.IsEmpty());

Console.WriteLine();
MyStack<double> doubleStack = new MyStack<double>();
doubleStack.Push(1.1);
doubleStack.Push(2.2);
Console.WriteLine("Top of doubleStack: " + doubleStack.Peek());
Console.WriteLine("Popped from doubleStack: " + doubleStack.Pop());
Console.WriteLine("doubleStack is empty? " + doubleStack.IsEmpty());
