class Program
{
    static void Main()
    {
        
        int[] numbers = { 7, 3, 9, 1, 5 };

       Array.Sort(numbers);

       Array.Reverse(numbers);

        
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Index " + i + " = " + numbers[i]);
        }

      
        int position = Array.IndexOf(numbers, 5);
        Console.WriteLine("Position of 5 = " + position);
    }
}