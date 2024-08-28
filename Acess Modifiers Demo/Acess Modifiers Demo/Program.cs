using AnotherAssembly;

namespace Acess_Modifiers_Demo
{
    internal class Program
    {
        //I'm not covering public members. It is just the most permissive member in or out the assembly
        static void Main(string[] args)
        {
            Some_Class_In_Another_Assembly classOtherAssembly = new Some_Class_In_Another_Assembly();
            classOtherAssembly.Chat_With_Neighboring_Classes();

            Derived_Class_In_Another_Assembly derivadClassOtherAssembly = new Derived_Class_In_Another_Assembly();
            derivadClassOtherAssembly.Say_Hi_Protected_Member_In_Another_Assembly();

            Derived_Class_A derivedClass = new Derived_Class_A();
            derivedClass.Chat_With_Neighboring_Classes();

            Some_class someClass = new Some_class();
            someClass.Chat_With_Neighboring_Classes_from_another_assembly();

        }
    }
}
