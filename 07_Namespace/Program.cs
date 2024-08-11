
Console.WriteLine("Hello, World!");
NS1.Foo foo1 = new NS1.Foo(10);
foo1.display();

NS2.Foo foo2 = new NS2.Foo(30);
foo2.display();

namespace NS1{
    class Foo{

        int x;

        public Foo(int x){
            this.x = x;
        }

        public void display(){
            System.Console.WriteLine("Value of x: " + this.x);
        }
    }
}

namespace NS2{
    class Foo{

        int x;

        public Foo(int x){
            this.x = x;
        }

        public void display(){
            System.Console.WriteLine("Value of x: " + this.x);
        }
    }
}