using System.Collections;

namespace Model{
    class Person{
    
        int? id;
        string? name;

        ArrayList? phoneNumbers;

    
        Person(int id){
            this.id = id;
        }
        public Person(int id, string name, ArrayList phoneNumbers) : this(id){
            // this.id = id;
            this.name = name;
            this.phoneNumbers = phoneNumbers;
        }

        public void display(){
            System.Console.WriteLine("The Person Name: {0} ", this.name);
            System.Console.WriteLine("The Person id: {0} ", this.id);
            
            if(this.phoneNumbers != null){
                foreach(var phonenumber in this.phoneNumbers){
                    System.Console.WriteLine("The Person phone number: {0} ", phonenumber);
                }
            }
        }
    }
}