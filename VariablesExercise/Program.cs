using System.Net;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string destination = "Cancun";
            int numberOfGuests = 2;
            char currency = '$';
            bool isSummer = true;
            double costOfDrink = 5.50;
            decimal costOfMeal = 15.95m;

            Console.WriteLine($"This Summer I'm going to {destination} with my husband, just the {numberOfGuests} of us. The whole trip cost {currency}500 and that is {isSummer}! One margarita costs ${costOfDrink} and one burrito costs ${costOfMeal}.");
        }
    }
}
