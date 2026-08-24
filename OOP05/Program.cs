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

            #region Q4 Extension Methods

            // a) What is an Extension Method?
            // It allows developers to add new methods to existing types without modifying the original code, inheriting from it, or recompiling it.

            // b) What keyword must be used in the first parameter of an extension method?
            // The 'this' keyword preceding the parameter type.

            // c) Where must an extension method be declared?
            // Inside a top-level static class as a static method.

            // d) Can an extension method access private members of the class it extends?
            // No, extension methods can only access public (and internal, if in the same assembly) members of the extended class.

            #endregion

            #region Q5 Partial Classes and Partial Methods

            // a) What is a Partial Class?
            // A feature that allows the definition of a single class to be split across multiple .cs source files within the same assembly.

            // b) Why would a developer split one class into multiple files?
            // To improve maintainability in large codebases, separate concerns (e.g., core logic vs tracking logic), or preserve custom logic alongside auto-generated code.

            // c) What is a Partial Method?
            // A method declared in one partial class file (signature) and optionally implemented in another partial class file.

            // d) What happens if a declared partial method has no implementation?
            // The C# compiler removes the method declaration, its call sites, and any performance overhead during compilation (zero runtime impact).

            #endregion

            #region Program
            DeliveryUtilities.PrintSystemTitle("Smart Delivery Management System");

            Console.WriteLine("Creating Shipments...");
            Console.WriteLine("==========================================");

            StandardShipment sh1 = new StandardShipment("SH001", "Laptop", 3, 80, new DeliveryAddress("Tahrir", "Cairo"));
            Console.WriteLine("Standard Shipment Created");

            ExpressShipment sh2 = new ExpressShipment("SH002", "Mobile Phone", 2, 60, new DeliveryAddress("Nile", "Cairo"), 30);
            sh2.TrackingStatus = "Out For Delivery";
            Console.WriteLine("Express Shipment Created");

            InternationalShipment sh3 = new InternationalShipment("SH003", "Television", 8, 120, new DeliveryAddress("Berlin", "Germany"), "Germany", 100);
            sh3.TrackingStatus = "Delivered";
            Console.WriteLine("International Shipment Created");

            Console.WriteLine($"Total Shipments Created: {Shipment.GetTotalShipmentsCreated()}");
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Object Copying");
            Shipment shipment2 = sh1;
            Console.WriteLine($"Original Shipment: {sh1.TrackingCode}");
            Console.WriteLine($"Assigned Shipment: {shipment2.TrackingCode}");
            Console.WriteLine($"Same Object: {object.ReferenceEquals(sh1, shipment2)}");
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Shallow Copy");
            Shipment shallowCopied = sh1.ShallowCopy();
            Console.WriteLine($"Original Shipment Address: {sh1.Destination.City}");
            Console.WriteLine($"Copied Shipment Address  : {shallowCopied.Destination.City}");

            Console.WriteLine("Changing copied shipment address...");
            shallowCopied.Destination.City = "Giza";

            Console.WriteLine($"Original Shipment Address: {sh1.Destination.City}");
            Console.WriteLine($"Copied Shipment Address  : {shallowCopied.Destination.City}");
            Console.WriteLine($"Same DeliveryAddress Object: {object.ReferenceEquals(sh1.Destination, shallowCopied.Destination)}");
            DeliveryUtilities.PrintSeparator();

            sh1.Destination.City = "Cairo";

            Console.WriteLine("Deep Copy");
            Shipment deepCopied = sh1.DeepCopy();
            Console.WriteLine($"Original Shipment Address: {sh1.Destination.City}");
            Console.WriteLine($"Copied Shipment Address  : {shallowCopied.Destination.City}");

            Console.WriteLine("Changing copied shipment address...");
            deepCopied.Destination.City = "Giza";

            Console.WriteLine($"Original Shipment Address: {sh1.Destination.City}");
            Console.WriteLine($"Copied Shipment Address  : {deepCopied.Destination.City}");
            Console.WriteLine($"Same DeliveryAddress Object: {object.ReferenceEquals(sh1.Destination, deepCopied.Destination)}");
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Extension Methods");
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine(sh1.GetSummary());
            Console.WriteLine(sh2.GetSummary());
            Console.WriteLine(sh3.GetSummary());

            Console.WriteLine($"SH001 Is Delivered: {sh1.IsDelivered()}");
            Console.WriteLine($"SH003 Is Delivered: {sh3.IsDelivered()}");
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Tracking Status");
            DeliveryUtilities.PrintSeparator();
            sh1.UpdateTrackingStatus("Out For Delivery");

            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Static Utilities");
            Console.WriteLine("Delivery Center");
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine($"Total Shipments Created: {Shipment.GetTotalShipmentsCreated()}");

            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Partial Method");
            DeliveryUtilities.PrintSeparator();
            sh1.UpdateTrackingStatus("Delivered");

            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Assignment Completed");
            DeliveryUtilities.PrintSeparator();

            Console.ReadKey();

            #endregion
        }
    }
}
