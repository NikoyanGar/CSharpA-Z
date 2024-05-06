namespace _011_Basic_Data_Types
{
    //Every OBJECT has toString()
    internal class Program
    {
        static void Main(string[] args)
        {
            //object obj = null;
            //object obj1 = null;
            object obj = 1;
            object obj1 = 1;

            //obj = new Object();
            //obj1 = new Object();

            Console.WriteLine(obj.ToString());
            Console.WriteLine(obj1.ToString());

            bool isEquals = obj.Equals(obj1);

            bool isRefEquals = ReferenceEquals(obj, obj1);

            int hashCodeOfObj = obj.GetHashCode();

            int hashCodeOfObj1 = obj1.GetHashCode();

            obj1 = obj;

            int hashCode = obj.GetHashCode();
            int hashCode1 = obj1.GetHashCode();

            bool isEquals1 = obj.Equals(obj1);

            bool isRefEquals1 = ReferenceEquals(obj, obj1);
        }
    }
}
