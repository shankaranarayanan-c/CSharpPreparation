int x = 10;
ParamsRefOut paramsRefOut = new ParamsRefOut();
paramsRefOut.refMethod(ref x);
System.Console.WriteLine("The ref param value: {0}", x);

int y;
paramsRefOut.outMethod(out y);
System.Console.WriteLine("The out param value: {0}", y);





class ParamsRefOut{

    public int refMethod(ref int i){                            // passes reference can be read or modified only initialized param are allowed to be sent as ref
        return i++;
    }

    public int outMethod(out int i){                            // passes referece and can be uninitialized by the param has to be initialized within out method
        i = 100;
        return i;
    }
}