using System;

class Program{
    static void Main(){

        //implicit type conversion or upcasting where no loss of data
        byte aNumber = 200;
        int bNumber = aNumber;
        System.Console.WriteLine("Integer Value is : {0}", bNumber);

        //explicit casting or downcasting where there may be data loss
        int cNumber = 300;
        byte dNumber = (byte)cNumber;
        System.Console.WriteLine("Byte value is : {0}" , dNumber);              //undefined behaviour when there is a overflow

        //casting for non compatible types
        var aString = "79";
        int eNumber = Convert.ToInt32(aString);                                 //Also throws exception if the conversion is unsuccessful
        System.Console.WriteLine("Integer value is: {0}", eNumber);

        try
        {
            bool fNumber = bool.Parse(aString);
            System.Console.WriteLine("Byte value is: {0}", fNumber);
        }
        catch (System.Exception)
        {
            
            System.Console.WriteLine("Unable to convert string to a valid bool value!");
        }

       
    }
}