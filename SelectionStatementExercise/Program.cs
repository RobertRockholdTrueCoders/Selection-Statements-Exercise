namespace SelectionStatementExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int favNumber = 13;
            Console.WriteLine("Guess my favorite number:");
            int userInput = int.Parse(Console.ReadLine());

            if (favNumber == userInput)
            {
                Console.WriteLine("Congratulations!");
            }
            else if (favNumber > userInput)
            {
                Console.WriteLine("Gotta be a bigger number than that!");
            }
            else
            {
                Console.WriteLine("Who can even count this high?");
            }

            ExerciseTwo();
            
        }
        public static void ExerciseTwo()
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();
    
            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a great subject");
                    break;
                case "english":
                    Console.WriteLine("Bobby, you speak English.");
                    break;
                case "lunch":
                    Console.WriteLine("You're probably failing, but at least you're not hungry.");
                    break;
                case "history":
                    Console.WriteLine("It's in the past.");
                    break;
                case "science":
                    Console.WriteLine("Science is realizing we know nothing.");
                    break;
                default:
                    Console.WriteLine($"{favoriteSubject} is definitely a subject.");
                    break;
            }
        }
    }
}
