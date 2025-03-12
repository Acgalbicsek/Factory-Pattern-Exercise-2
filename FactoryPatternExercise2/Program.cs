namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use?");
            var input = Console.ReadLine();
            IDataAccess db = DataAccessFactory.GetDataAccessType(input);

            var products = db.LoadData();
            db.SaveData();

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }

        }
    }
}
