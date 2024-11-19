namespace Assignment_3_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 4 numbers separated by a space: "); //Requests user input and converst the input into an array. 
            string userInput = Console.ReadLine();
            string[] inputNumbers = userInput.Split(" ");

            int[] numbers = Array.ConvertAll(inputNumbers, int.Parse); 

            CalculateTotalAndAverage(out int total, out double average, numbers);

            Console.WriteLine($"\nThe sum of your four numbers is: {total} ");
            Console.WriteLine($"\nThe average of your four numbers is: {average}");

        }

        static void CalculateTotalAndAverage(out int total, out double average, int[] numbers)
        {
            total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            average = (double)total / numbers.Length;
            
        }
    }
}
        
      


