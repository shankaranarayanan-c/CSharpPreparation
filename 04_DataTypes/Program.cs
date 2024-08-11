using System;

class Program{
    static void Main(){
        byte aByte = 3;
        Console.WriteLine("The byte value is: " + aByte);

        short aShort = 10;
        Console.WriteLine("The short value is: " + aShort);

        int aInt = 56;
        Console.WriteLine("The int value is: "+ aInt);

        long aLong = 12341235;
        Console.WriteLine("The long value is: "+ aLong);

        float aFloat = 12.34f;
        Console.WriteLine("The float value is: "+ aFloat);

        double aDouble = 12.234523;
        Console.WriteLine("The double value is: "+ aDouble);

        decimal aDecimal = 12.234523365341465m;
        Console.WriteLine("The decimal value is: "+ aDecimal);

        char aChar = 'a';
        Console.WriteLine("The char value is: "+ aChar);

        bool aBool = true;
        Console.WriteLine("The bool value is: "+ aBool);

        string aString = "Hi";
        System.Console.WriteLine("The string value is: " + aString);

        var aVar = 234;
        System.Console.WriteLine("The var value is: "+ aVar);

        System.Console.WriteLine("The byte minvalue: {0} maxvalue: {1}",byte.MinValue, byte.MaxValue);
    }
}