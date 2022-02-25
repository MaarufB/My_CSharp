using System;
using System.Collections;

namespace StackStructure
{
    class Program
    {

        // Stack is a datastructure implemented in .NET Framework
        // The principle of stack structure operation is LIFO (last in first out)
        // The last element entered first out 


        static void Main(string[] args)
        {

            Stack myStack = new Stack();
            
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            PrintStack(myStack);
        }
    
        private static void PrintStack(IEnumerable myCollection)
        {
            foreach(var item in myCollection){
                Console.WriteLine($"{item}");
            }
        }
    
    }
}
