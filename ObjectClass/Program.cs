namespace ObjectClass
{
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
//1.We start by declaring two variables obj and obj1 of type object. Initially, they are assigned the value 1.
//2.	We then call Console.WriteLine(obj.ToString()) to print the string representation of obj to the console. In this case, it will print 1.
//3.	Next, we call Console.WriteLine(obj1.ToString()) to print the string representation of obj1 to the console. Again, it will print 1.
//4.	We then call obj.Equals(obj1) to check if obj is equal to obj1. Since both obj and obj1 have the same value 1, the result will be true.
//5.	Next, we call ReferenceEquals(obj, obj1) to check if obj and obj1 refer to the same object. In this case, they do not refer to the same object, so the result will be false.
//6.	We then call obj.GetHashCode() to get the hash code of obj. The hash code is a unique identifier for an object. In this case, it will return the hash code of the value 1.
//7.	Similarly, we call obj1.GetHashCode() to get the hash code of obj1. Since obj1 also has the value 1, it will return the same hash code as obj.
//8.	Next, we assign obj1 the value of obj using the statement obj1 = obj.Now both obj and obj1 refer to the same object with the value 1.
//9.	We then call obj.GetHashCode() and obj1.GetHashCode() again to get the hash codes. Since both variables refer to the same object, they will return the same hash code.
//10.	Finally, we call obj.Equals(obj1) and ReferenceEquals(obj, obj1) again. Since both variables refer to the same object with the value 1, the result will be true for both comparisons.
