public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void DoSomething()
    {
        try
        {
            // Some code that might throw an exception
            // ...
        }
        catch (Exception ex)
        {
            // Handle exception and restore object to a valid state
            Console.WriteLine(ex.Message);
            _value = 0; // Reset to a default value
            // Consider throwing a custom exception or logging the error for further analysis
        }
    }
} 