using System.Security.Cryptography.X509Certificates;

namespace G_NET_101_Advanced_01
{
    #region Q.1
    //A generic Class is a class that can work with any data type. It allows you to define a class with a placeholder for the data type, which can be specified when creating an instance of the class. This provides flexibility and reusability in your code.
    //Use generics for cleaner code, type safety, and performance. Generics allow you to create classes, methods, and data structures that can work with any data type while maintaining type safety. This means that you can catch type-related errors at compile time rather than at runtime, which can help prevent bugs and improve the overall quality of your code.
    #endregion

    #region Q.2
    //public class Container<T>
    //{
    //    T item;

    //    public void Add(T value)
    //    {
    //        this.item = value;
    //    }

    //    public T Get()
    //    {
    //        return this.item;
    //    }


    //}
    #endregion

    #region Q.3
    //Multiple type parameters can be used in a generic class by specifying multiple type parameters in the class definition. Each type parameter can be used independently within the class, allowing for greater flexibility and reusability of the class.
   public class Pair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }

    public Pair(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }
}


    #endregion

    #region Q.4
    //A generic method is a method that can work with any data type. It allows you to define a method with a placeholder for the data type, which can be specified when calling the method. This provides flexibility and reusability in your code.
    public class GenericMethodExample
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    #endregion

    #region Q.5

    //public class FindMaxExample
    //{
    //    public static T FindMax<T>(T a, T b) where T : IComparable<T>
    //    {
    //        T maxValue;
    //        if(a.CompareTo(b) > 0)
    //        {
    //            maxValue = a;
    //        }
    //        else
    //        {
    //            maxValue = b;
    //        }
    //        return maxValue;
    //    }
    //}


    #endregion

    #region Q.6
    //A generic interface is an interface that can work with any data type. It allows you to define an interface with a placeholder for the data type, which can be specified when implementing the interface. This provides flexibility and reusability in your code.
    public interface Irepository<T>
    { 
    void Add(T item);
    T Read(T item);
     void Update(T item);
     void Delete(T item);
    }


    #endregion

    #region Q.7
    //The struct constraint in C# is used to restrict the types that can be used as type parameters in a generic class or method. When you apply the struct constraint to a type parameter, it means that the type argument must be a value type (i.e., a struct) and cannot be a reference type (i.e., a class). This constraint ensures that the generic type can only be instantiated with value types, which can help improve performance and reduce memory overhead in certain scenarios.
    public class Container<T> where T : struct
    {
        public T Value { get; set; }

        public Container(T value)
        {
            Value = value;
        }
    }


    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {



        }
    }
}

