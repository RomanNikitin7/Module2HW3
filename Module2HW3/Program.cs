namespace Module2HW3
{
    public class Program
    {
        static void Main(string[] args)
        {
            ISweet[] sweets =
            {
                new Chocolate("Mars", 20, "Dark"),
                new Candy("Jelly Bean", 10, "Fruit"),
                new Lollipop("Chupa Chups", 5, "Strawberry", "Red")
            };

            Gift gift = new Gift();

            ISweet foundSweet = gift.FindSweetByParameter(sweets, isChocolate: true, minWeight: 15, name: "Mars");

            if (foundSweet != null)
            {
                Console.WriteLine($"Found sweet: {foundSweet.GetDescription()}");
            }
            else
            {
                Console.WriteLine("No matching chocolate sweet found.");
            }
        }
    }
}
