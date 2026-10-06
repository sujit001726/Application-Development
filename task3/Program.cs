class Program
{
    static void Main()
    {
      
        byte myByte = 255;
        short myShort = 32000;
        int myInt = 42;
        long myLong = 9000000000;
        float myFloat = 3.5f;
        double myDouble = 19.99;
        decimal myDecimal = 1500.75m;
        char myChar = 'A';
        bool myBool = true;

       
        string intToString = myInt.ToString();

       
        double stringToDouble = double.Parse("3.14");

        
        Console.WriteLine("byte = " + myByte);
        Console.WriteLine("short = " + myShort);
        Console.WriteLine("int = " + myInt);
        Console.WriteLine("long = " + myLong);
        Console.WriteLine("float = " + myFloat);
        Console.WriteLine("double = " + myDouble);
        Console.WriteLine("decimal = " + myDecimal);
        Console.WriteLine("char = " + myChar);
        Console.WriteLine("bool = " + myBool);
        Console.WriteLine("string (from int) = " + intToString);
        Console.WriteLine("double (from string) = " + stringToDouble);
    }
}