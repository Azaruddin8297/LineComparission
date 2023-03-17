namespace LineComparisonProgram
{
    public class Lineprogram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the Line Comparison Compution Progarm");
           // CartisanSystem.method();
           CartisanSystem cs = new CartisanSystem();
            cs.method();
                Line line1 = new Line(0, 0, 1, 1);
                Line line2 = new Line(0, 0, 1, 1);

                // check if the lines are equal
                bool areEqual = line1.Equals(line2);

                // print the result
            
           Console.WriteLine($"The lines are equal: {areEqual}");


        }
    }
}
