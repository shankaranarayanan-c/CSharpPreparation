using System; 
using System.Threading;
using System.Threading.Tasks; 

Algo algo = new Algo();

var watch = new System.Diagnostics.Stopwatch(); 
// watch.Start(); 
// algo.dataPreparation();
// algo.algorithm1();
// algo.algorithm2();
// watch.Stop(); 
// Console.WriteLine($"Execution Time Without Async: {watch.ElapsedMilliseconds} ms"); 

watch.Reset();
watch.Start(); 
// var task1 = algo.dataPreparationTask();
// await task1;
var task2 = algo.producerTask();
var task3 = algo.consumerTask();
Task.WaitAll(task2, task3); 
watch.Stop(); 
Console.WriteLine($"Execution Time with Async: {watch.ElapsedMilliseconds} ms"); 

class Algo{

    int count;

    public void dataPreparation(){
        System.Console.WriteLine("Started Data Preparation");
        Thread.Sleep(3000);
        System.Console.WriteLine("Completed Data Preparation");
    }

    public void algorithm1(){
        System.Console.WriteLine("Algorithm 1 Started");
        Thread.Sleep(5000);
        System.Console.WriteLine("Algorithm 1 Ended");
    }

    public void algorithm2(){
        System.Console.WriteLine("Algorithm 2 Started");
        Thread.Sleep(6000);
        System.Console.WriteLine("Algorithm 2 Ended");
    }

    public async Task dataPreparationTask(){
        await Task.Factory.StartNew(() => {
            System.Console.WriteLine("Started Data Preparation");
            Thread.Sleep(3000);
            System.Console.WriteLine("Completed Data Preparation");
        }
        );
    }

    public async Task producerTask(){
        await Task.Factory.StartNew(() => {
            System.Console.WriteLine("Producer Started");
            for(int i=0; i< 10; i++){
             accessData(true, i);
             System.Console.WriteLine("Sent Data: {0}", i);
             Thread.Sleep(500);
            }
            
            System.Console.WriteLine("Producer Ended");
        }
        );
    }

    public async Task consumerTask(){
        await Task.Factory.StartNew(() => {
            System.Console.WriteLine("Consumer Started");
            
            for(int i=0; i< 10; i++){
             int data = accessData(false, i);
             System.Console.WriteLine("Received Data: {0}", data);
             Thread.Sleep(500);
            }
            System.Console.WriteLine("Consumer Ended");
        }
        );
    }

    private int accessData(bool readWriteFlag, int value){
        object obj = new object();
        lock(obj){
             if(readWriteFlag){
                this.count = value;
             }
        }
        return this.count;
    }

}

