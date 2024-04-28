namespace ValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25; // Example of an integer value type
                          //double salary = 50000.50; // Example of a double value type
                          //char grade = 'A'; // Example of a character value type
                          //bool isStudent = true; // Example of a boolean value type

            int age1 = age;
            Console.WriteLine("age1: " + age1); // Output: age1: 25

            age = 26;
            Console.WriteLine("age: " + age); // Output: age: 26
        }
    }
}

//1.We start by declaring a variable age of type int and assigning it the value 25.
//2.	Next, we declare another variable age1 of type int and assign it the value of age.
//This means that age1 now holds the same value as age.
//3.	We use Console.WriteLine to print the value of age1 to the console. The output will be age1: 25.
//4.We then assign a new value 26 to the age variable.
//5.	Finally, we use Console.WriteLine again to print the updated value of age to the console.
//The output will be age: 26.
//So, the code demonstrates the concept of assigning values to variables and how changing the value of one variable
//does not affect the value of another variable that was assigned the original value.
