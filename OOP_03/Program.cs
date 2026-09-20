namespace OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1 question1
            ////a)Method Overloading:Occurs when multiple methods in the same class share the same name but have different parameters
            ////(different type, number, or order of parameters)It does not require inheritance.

            ////Method Overriding:Occurs when a child (derived) class provides a specific implementation for a method that is already defined
            //// in its parent(base)class The method must have the exact same name, return type, and parameters
            ////It requires inheritance and the use of virtual or abstract in the parent class, and override in the child class.

            ////b)Static Binding (Early Binding):The method call is resolved by the compiler at compile-time
            ////This happens with normal methods and method overloading.The compiler knows exactly which method to execute based on the reference type.

            ////Dynamic Binding (Late Binding):The method call is resolved at run-time based on the actual object type created in memory,
            //// not the reference type. This happens with method overriding (when virtual/override keywords are used).
            #endregion
            #region Part1 question2
            ////a)The sealed keyword prevents a class from being inherited. When a class is marked as sealed, no other class can derive from it
            ////It is used to protect the code from being altered via inheritance and can occasionally provide minor performance optimizations.

            ////b)Sealed Class: Prevents the entire class from being inherited. You cannot create a child class from it.

            ////Sealed Method: Prevents a specific overridden method from being overridden further by classes lower in the inheritance hierarchy.

            ////c)No. A sealed method cannot be overridden.The fundamental reason for applying the sealed keyword to a method 
            ////is to explicitly stop the inheritance chain for that specific behavior
            #endregion
        }
    }
}
