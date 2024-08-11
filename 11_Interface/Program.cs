AutonomousDriving ad = new AutonomousDriving();
ad.totalObjectsDetected("data");
ObjDetectionAlgorithm.display();

interface ObjDetectionAlgorithm{

    // int totalSensors;                                        // cannot have instance fields

    static int totalSensors;                                    // Interface cannot have instance fields only static and abstract methods

    int totalObjectsDetected(string data);

    static void display(){
        System.Console.WriteLine("Interface Hello!");
    }
    
}

class AutonomousDriving : ObjDetectionAlgorithm{

    static AutonomousDriving(){
        ObjDetectionAlgorithm.totalSensors = 10;
    }

    public int totalObjectsDetected(string data){
        System.Console.WriteLine("hi {0}", data);
        return 0;
    }
}