public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property

    public void MyMethod()
    {
        // Initialize MyProperty to a default value or another value
        MyProperty = 10;
        Console.WriteLine(MyProperty); 
    }
}