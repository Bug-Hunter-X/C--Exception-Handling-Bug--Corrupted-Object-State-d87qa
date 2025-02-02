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
        // Some code that might throw an exception
        try
        {
            // ...
        }
        catch (Exception ex)
        {
            // Handle exception
            Console.WriteLine(ex.Message);
            //Here's the bug:  The exception is handled, but the program continues execution with the potentially corrupted state of this object.  The field '_value' might be left in an invalid state after an exception.
        }
    }
}