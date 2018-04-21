using System;
public class Function
{
    protected Function()
    {

    }
    public object thisArg;
    public object[] argArray;
    public object prototype;
    public float length;
    public object arguments;
    public Function caller;
    public object apply(Function this1, object thisArg, object argArray = default(object))
    {
        throw new System.NotImplementedException();
    }
    public object call(Function this1, object thisArg, params object[][] argArray)
    {
        throw new System.NotImplementedException();
    }
    public object bind(Function this1, object thisArg, params object[][] argArray)
    {
        throw new System.NotImplementedException();
    }
}
