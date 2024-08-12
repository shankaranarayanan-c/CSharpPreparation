

public delegate void display(int value);
class Program{

    public static void add(int x, int y, display d){
        d(x+y);
    }

    static void Main(){
        display d = delegate(int value){
            System.Console.WriteLine("The value is {0}", value);
        };

        d(100);
        add(5, 4, d);
    }
}