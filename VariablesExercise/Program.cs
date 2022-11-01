namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
        

            string dogName = "Feijao";
            int age = 2;
            char firstLetterToy = 'B';
            bool lovesRunning = true;
            double fluffyToys = 30;
            decimal weight = 59.5m;
            
            Console.WriteLine($"Hello, my name is {dogName} and I love to play! I am {age} years old and {weight} pounds." +
                $"It is {lovesRunning} that I love ruuning and that I have {fluffyToys} toys. My favorite thing to chew on starts with the letter {firstLetterToy}.");
            Console.ReadLine();
        }
    }
}
