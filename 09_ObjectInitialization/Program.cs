// See https://aka.ms/new-console-template for more information

// Person p1 = new Person(1);
Person p1 = new Person() {id = 1};
System.Console.WriteLine("Person id: {0}", p1.id);

var p2 = new Person() {id = 2};
System.Console.WriteLine("Person id: {0}", p2.id);

var p3 = new {id = 3};                                                      // Anonymous object created using LINQ
System.Console.WriteLine("Person id: {0}", p3.id);

Book b1 = new Book(){name ="Foo", author ="Bar"};                           // Cant construct book without author as it is required
b1.name = "Bar";

BankAccount bankAccount = new BankAccount(){accNo=123, customerName="Goo"};
// bankAccount.accNo = 321;                                                 // Cant modify the accNo as it is init and should be initialized at runtime and cant be modified
bankAccount.customerName = "Moo";

StringVal stringVal = new StringVal("Hi");
// stringVal.value = "Hello";                                                  // unmodifiable property

class Person{
    public int id {get; set;}

//     public Person(int id){
//         this.id = id;
//     }
}

class Book{
    public required string name {get;set;}
    public string? author {get;set;}

}


class BankAccount{
    public int accNo{init; get;}
    public string? customerName{set;get;}
}

class StringVal{
    public readonly string value;                                   //readonly can have properties

    public StringVal(string value){                                 //readonly can be initialized only within constructor unline init where object initialization can be done
        this.value = value;
    }
}