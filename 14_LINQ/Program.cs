
// 1. Data source
int[] numbers = {9, 4, 7, 1, 6, 3, 8, 2, 0, 5};

// 2. Query creation
var query = from num in numbers where (num > 5) select num;        // returns anonymous objects to immeediately execute and cache the results use .toList() or .toArray()

// 3. Execute query

foreach (int num in query){
    System.Console.WriteLine("values are {0}", num);
}

