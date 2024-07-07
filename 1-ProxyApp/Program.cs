internal class Program
{
    private static void Main(string[] args)
    {
        var b1 = new BusinessModule();
        b1.Method();
        Console.WriteLine("------------------------");

        var b2 = new BusinessModuleProxy();
        b2.Method();
    }
}

public interface IBusinessModule
{
    void Method();
}

public class BusinessModule : IBusinessModule
{
    public void Method()
    {
        Console.WriteLine("Method ...");
    }
}

public class BusinessModuleProxy : IBusinessModule
{
    private BusinessModule _realObject;

    public BusinessModuleProxy()
    {
        _realObject = new BusinessModule();
    }

    public void Method()
    {
        Console.WriteLine("Before method.");
        _realObject.Method();
        Console.WriteLine("After method.");
    }
}