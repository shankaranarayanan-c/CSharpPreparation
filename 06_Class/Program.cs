using Model;
using System;
using System.Collections;

class Program{
    static void Main(){
        ArrayList phoneNumbers = new ArrayList();
        phoneNumbers.Add(1234567890);
        phoneNumbers.Add(0987654321);
        var person = new Person(1, "Foo", phoneNumbers);

        person.display();
        
    }
}