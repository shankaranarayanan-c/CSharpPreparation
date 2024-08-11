// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Person p1 = new Person(1, "Foo");
Person p2 = new Person(1, "Foo");

if(p1 == p2){
    System.Console.WriteLine("The person records are equal!");
}else{
    System.Console.WriteLine("The person records are not equal");
}

// p1.setID(20);
// System.Console.WriteLine("ID is: {0}", p1.id);

public sealed record class Person{                                            // if record keyword is removed then the equality check fails
    private readonly int id; 

    string name;

    public Person(int id, string name){
        this.id = id;
        this.name =name;
    }

    // public int getId(){
    //     return id;
    // //     // set {id = value;}
    // }

    // public void setID(int id){
    //     this.id = id;
    // }
}