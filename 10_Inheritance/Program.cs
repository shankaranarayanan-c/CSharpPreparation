
FooBase fooBase = new FooBase(10);
FooDerived fooDerived = new FooDerived(20);
fooBase.display();
fooDerived.display();

//Trying polymorphic behaviour
FooBase fooBase1 = new FooDerived(40);
fooBase1.display();                                                 // The fooBase1 calls the base class instead of derived class


Polymorphic.FooBase fooBase2 = new Polymorphic.FooDerived(40);
fooBase2.display();                                                 // virtual and override keywords enable polymorphic behaviour


class FooBase
{
    int x;

    public FooBase(int x){
        this.x =x;
    }

    public void display(){
        System.Console.WriteLine("Base Class x: {0}", this.x);
    }
}

class FooDerived : FooBase
{

    int y;

    public FooDerived(int y):base(y){
        this.y = y;
    }

    public void display(){
        System.Console.WriteLine("Derived Class x: {0}", this.y);
    }
}

namespace Polymorphic{
        class FooBase
    {
        int x;

        public FooBase(int x){
            this.x =x;
        }

        public virtual void display(){
            System.Console.WriteLine("Base Class x: {0}", this.x);
        }
    }

    class FooDerived : FooBase
    {

        int y;

        public FooDerived(int y):base(y){
            this.y = y;
        }

        public override void display(){
            System.Console.WriteLine("Derived Class x: {0}", this.y);
        }
    }
}

namespace RestrictInheritance{
        sealed class FooBase
    {
        int x;

        public FooBase(int x){
            this.x =x;
        }

        public void display(){
            System.Console.WriteLine("Base Class x: {0}", this.x);
        }
    }

    // class FooDerived : FooBase                                           //cant inherit a sealed class
    // {

    //     int y;

    //     public FooDerived(int y):base(y){
    //         this.y = y;
    //     }

    //     public override void display(){
    //         System.Console.WriteLine("Derived Class x: {0}", this.y);
    //     }
    // }
}