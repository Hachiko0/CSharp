using System;

class AssignStringToObject
{

    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object helloWorld = hello + " " + world;
        string copyHelloWorld = (string)helloWorld;
        Console.WriteLine(helloWorld);
        Console.WriteLine(copyHelloWorld);
    }
}
