using System;
public class invalidAgeException : Exception
{
    public invalidAgeException(string message) : base(message)
    {

    }
}
public class Test
{
    static void validate(int age)
    {
        if (age > 18)
        {
            throw new invalidAgeException("enter correct age");

        }
    }
    public static void Main(String[] args)
    {
        try
        {
            validate(25);
        }
        catch (invalidAgeException e) {
            Console.WriteLine(e);
                }
        finally{
            Console.WriteLine("completed");
        }
    }
}


