using System.Collections.Generic;


Calculator<int> intCalculator = new Calculator<int>();
System.Console.WriteLine("Int Calculator: {0}", intCalculator.add(3,6));

Calculator<string> stringCalculator = new Calculator<string>();
System.Console.WriteLine("String Calculator: {0}", stringCalculator.add("Hello","World"));

// class T{

//     public static T operator +(T x, T y){
//         return x+y;
//     }
// }


class Calculator<T> {

    public T add(T x, T y){
        dynamic a = x;
        dynamic b = y;
        return a + b;
    }
}