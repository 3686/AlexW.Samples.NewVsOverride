using System;

namespace ConsoleApplication
{
    public class BaseClass {
        public virtual void PrintMessage() {
            Console.WriteLine("BaseClass message");
        }
    }

    public class UsingNewSubclass : BaseClass {
        public new void PrintMessage() {
            base.PrintMessage();
            Console.WriteLine("UsingNewSubclass message");
        }
    }

    public class UsingOverrideSubclass : BaseClass{
        public override void PrintMessage() {
            base.PrintMessage();
            Console.WriteLine("UsingOverrideSubclass message");
        }
    }

    public class Program
    {
        private static void TestInferredTypes() {
            Console.WriteLine("--- using inferred at runtime types ---");
            Console.WriteLine("--- BaseClass ---");
            var baseInstance = new BaseClass();
            baseInstance.PrintMessage();

            Console.WriteLine("--- UsingNewSubclass ---");
            var usingNewSubclassInstance = new UsingNewSubclass();
            usingNewSubclassInstance.PrintMessage();

            Console.WriteLine("--- UsingOverrideSubclass ---");
            var usingOverrideSubclassInstance = new UsingOverrideSubclass();
            usingOverrideSubclassInstance.PrintMessage();

             Console.WriteLine();
        }

        public static void TestSpecifiedTypes() {
            Console.WriteLine("--- testing using base types ---");

            Console.WriteLine("--- BaseClass ---");
            ((BaseClass) new BaseClass()).PrintMessage();

            Console.WriteLine("--- UsingNewSubclass used as a BaseClass type ---");
            ((BaseClass) new UsingNewSubclass()).PrintMessage();

            Console.WriteLine("--- UsingOverrideSubclass used as a BaseClass type ---");
            ((BaseClass) new UsingOverrideSubclass()).PrintMessage();

            Console.WriteLine();
            Console.WriteLine("Note: We use the BaseClass for all invocations here");
            Console.WriteLine("Note: The UsingNewSubclass instance does allow the new method to be visible to the base class, it's only available on subclasses, so only the base method is called");
            Console.WriteLine("Note: The UsingOverrideSubclass instance method overrides the instance on the type, however retains the parent, so both are called");

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            TestInferredTypes();
            TestSpecifiedTypes();            
        }
    }
}
