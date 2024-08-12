using System;

Foo foo = new Foo();
var name = foo.getName();
System.Console.WriteLine("The name is {0} {1} {2}", name.firstName, name.middleName, name.lastName);

//discard the tuple values
var(firstName,_,lastName) = foo.getName();
System.Console.WriteLine("The name is {0} {1}", firstName, lastName);

//discard out parameters
int a = 10;
int b = 20;
foo.bar(out a, out b);
foo.bar(out a, out _);

//deconstruct obj
Foo foo1 = new Foo();
foo1.xValue = 10;
System.Console.WriteLine("Foo X: {0}", foo1.xValue);

foo1.y = 20;
System.Console.WriteLine("Foo Y: {0}", foo1.y);

foo1.z = "Hi";
System.Console.WriteLine("Foo Z: {0}", foo1.z);

var(m,n) = foo1;

class Foo{

    int x;
    public int y {get; set;}

    public string z {get; set;}

    public (string firstName, string middleName, string lastName) getName(){
        return ("Foo","Bar","Moo");
    }

    public void bar(out int x, out int y){
        x = 10;
        y = 20;
    }

    public int xValue{
        get{
            return x;
        }

        set{
            x = value;
        }
    }

    public void deconstruct(out int m, out string n){
        m = x;
        n = z;
    }
}