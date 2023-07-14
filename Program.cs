using Quiz_App;

internal class Program
{
    private static void Main(string[] args)
    {
        Question q1 = new Question();
        Question q2 = new Question("Is hamburger an italian food?");
        Question q3 = new Question("What's the capital city of Hungary?", "Debrecen", "Budapest", "Bucharest", "Bangkok", 'B');
        Question q4 = new Question("Every Dr. is a doctor?") { optionA = "yes", optionB = "no", optionC = "maybe", optionD = "impossible" };

        Console.WriteLine("q1 (false): " + q1.AreOptionsValid());
        Console.WriteLine("q2 (false): " + q2.AreOptionsValid());
        Console.WriteLine("q3 (true): " + q3.AreOptionsValid());
        Console.WriteLine("q4 (true): " + q4.AreOptionsValid());
    }
}