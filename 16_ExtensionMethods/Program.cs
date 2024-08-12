using Extension;

int i = 10;
System.Console.WriteLine("Comparison result {0}", i.isGreaterThan(5));

namespace Extension{
    public static class intExtentsions{
        public static bool isGreaterThan(this int data, int comparison){
            return data > comparison;
        }
    }
}