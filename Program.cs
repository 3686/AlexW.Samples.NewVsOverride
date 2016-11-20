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
            Console.WriteLine("Note: Notice how the method using new doesn't know about the new method, because it's not overriden it, so the instance only knows about the base method");
            Console.WriteLine("Note: The second instance has been overriden so knows about the method heirarchy");

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            TestInferredTypes();
            TestSpecifiedTypes();            
        }
    }
}
