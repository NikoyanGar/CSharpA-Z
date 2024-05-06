namespace _004_Data_Type_Conversions
{
    //Convert Class
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string? age = Console.ReadLine(); //What about ?
            int integralAge = Convert.ToInt32(age);

            Console.Write("Enter your height: ");
            double height = Convert.ToDouble(Console.ReadLine());//Depends on OS '.,'

            Console.Write("Enter your salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());//Depends on OS '.,'


            Console.WriteLine($"name: {name}  age: {integralAge}  Height: {height}m  salary: {salary}$");
        }
    }
}
