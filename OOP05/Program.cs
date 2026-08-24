namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Object Copying

            // a) What happens when you assign one object variable to another object variable?
            // You copy the reference (memory address) of the object, not the actual object data. Both variables now point to the exact same object in the Heap memory.

            // b) Does assigning one object to another create a new object? Explain.
            // No, it does not create a new object. It only creates a new reference pointing to the existing object in memory.

            // c) What is the difference between copying an object and copying its reference?
            // Copying a reference creates another pointer to the same existing memory address (changes reflect on both). Copying an object allocates new memory and duplicates the values/state into a separate object instance.

            #endregion

            #region Q2 Shallow Copy vs Deep Copy

            // a) What is a Shallow Copy?
            // A shallow copy creates a new object instance and copies value-type fields directly, but for reference-type fields, it only copies their references (addresses).

            // b) What is a Deep Copy?
            // A deep copy creates a new object instance and recursively duplicates all objects referenced by it, producing fully independent copies for reference-type members.

            // c) What happens to reference-type members when a Shallow Copy is created?
            // They share the same memory references. Modifying a reference-type member in the copied object will affect the original object.

            // d) What happens to reference-type members when a Deep Copy is created?
            // New separate instances are created for them. Modifying a reference-type member in the copy does NOT affect the original object.

            // e) Give one situation where Deep Copy would be safer than Shallow Copy.
            // When cloning a complex object (like a Shipment with an Address or Items list) where you want to modify the copy's internal properties without unintentionally altering the original source data.
            #endregion

            #region Q3 Static Members

            // a) What is a static field, and how is it different from an instance field?
            // A static field belongs to the class itself and is shared among all instances (stored once in RAM). An instance field belongs to individual objects and each instance gets its own copy.

            // b) What is a static method? Can a static method directly access instance members?
            // A static method belongs to the class and can be invoked without instantiating an object. It CANNOT directly access instance members because it operates without a 'this' context.

            // c) What is a static constructor, and when is it executed?
            // A static constructor initializes static data or executes code once before the first instance is created or any static members are referenced. It is called automatically by the CLR.

            // d) What is a static class? Can you create an object from a static class?
            // A static class is a class marked with 'static' that contains only static members and cannot be inherited. No, you CANNOT create objects (instances) from it.

            #endregion
        }
    }
}
