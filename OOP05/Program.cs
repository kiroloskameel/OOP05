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
        }
    }
}
