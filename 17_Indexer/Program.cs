
IndexFoo indexFoo = new IndexFoo();
indexFoo[0] = "Hi";
indexFoo[1] = "Hello";
indexFoo[2] = "World";

System.Console.WriteLine("value: {0}", indexFoo[1]);

class IndexFoo
{
    string[] strings = new string[3];

    public string this[int index]{
        get{
            return strings[index];
        }

        set{
            strings[index] = value;
        }
    }

}