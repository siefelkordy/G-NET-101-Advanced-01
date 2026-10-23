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
    //public class Container<T> where T : struct
    //{
    //    public T Value { get; set; }

    //    public Container(T value)
    //    {
    //        Value = value;
    //    }
    //}

    #endregion

    #region Q.8
    //A class constraint in C# is used to restrict the types that can be used as type parameters in a generic class or method. When you apply the class constraint to a type parameter, it means that the type argument must be a reference type (i.e., a class) and cannot be a value type (i.e., a struct). This constraint ensures that the generic type can only be instantiated with reference types, which can help improve performance and reduce memory overhead in certain scenarios.
    //public class Container<T> where T : class
    //{
    //    public T Value { get; set; }
    //    public Container(T value)
    //    {
    //        Value = value;
    //    }
    //}

    #endregion

    #region Q.9
    //The new() constraint in C# is used to restrict the types that can be used as type parameters in a generic class or method. When you apply the new() constraint to a type parameter, it means that the type argument must have a public parameterless constructor. This constraint ensures that the generic type can only be instantiated with types that can be created using the default constructor, which can be useful when you need to create instances of the generic type within the class or method.
    //public class Container<T> where T : new()
    //{
    //    public T Value { get; set; }
    //    public Container()
    //    {
    //        Value = new T();
    //    }
    //}

    #endregion

    #region Q.10
    //The interface constraint in C# is used to restrict the types that can be used as type parameters in a generic class or method. When you apply the interface constraint to a type parameter, it means that the type argument must implement a specific interface. This constraint ensures that the generic type can only be instantiated with types that provide the required functionality defined by the interface, which can be useful when you need to work with specific behaviors or methods of the generic type.
    //public class Container<T> where T : IComparable<T>
    //{
    //    public T Value { get; set; }
    //    public Container(T value)
    //    {
    //        Value = value;
    //    }
    //    public bool IsGreaterThan(T other)
    //    {
    //        return Value.CompareTo(other) > 0;
    //    }
    //}

    #endregion

    #region Q.11
    //The base class constraint in C# is used to restrict the types that can be used as type parameters in a generic class or method. When you apply the base class constraint to a type parameter, it means that the type argument must inherit from a specific base class. This constraint ensures that the generic type can only be instantiated with types that derive from the specified base class, which can be useful when you need to work with specific properties or methods of the base class.
    //public class Container<T> where T : BaseClass
    //{
    //    public T Value { get; set; }
    //    public Container(T value)
    //    {
    //        Value = value;
    //    }
    //}
    #endregion

    #region Q.12
    //public class Container<T> where T : baseclass,IComparable<T>,new()
    //{
    //    public T Value { get; set; }
    //    public Container()
    //    {
    //        Value = new T();
    //    }
    //}
    #endregion

    #region Q.13
    //Default value of a generic type parameter in C# can be obtained using the default keyword. The default keyword returns the default value for the specified type parameter. For reference types, the default value is null, and for value types, it is the zero-initialized value (e.g., 0 for numeric types, false for bool, etc.). This allows you to handle cases where a generic type parameter may not have been assigned a specific value yet.
    #endregion

    #region Q.14
    public class SafeList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                return default(T);
            }

            return items[index];
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

