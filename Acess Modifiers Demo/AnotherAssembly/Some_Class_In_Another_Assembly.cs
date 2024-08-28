using System;
using System.Reflection;


namespace AnotherAssembly
{
    //I'm not covering public members. It is just the most permissive member in or out the assembly
    public class Some_Class_In_Another_Assembly
    {
        public void Chat_With_Neighboring_Classes()
        {
            Parent_Class_In_Another_Assembly neighbor_parent = new Parent_Class_In_Another_Assembly();

            try //trying to speak with a hide members
            {
                Type tipo = neighbor_parent.GetType(); //Get in touch with a hide member
                FieldInfo campo = tipo.GetField("Protected_Member_In_Another_Assembly", BindingFlags.NonPublic | BindingFlags.Instance);
                string valor = (string)campo.GetValue(neighbor_parent);
                Console.WriteLine("I'm in the same assembly, but I'm not a derived class. I only can see protected members using Reflection: " + valor);

                FieldInfo campoPrivate = tipo.GetField("PrivateMember", BindingFlags.NonPublic | BindingFlags.Instance);
                valor = (string)campoPrivate.GetValue(neighbor_parent);
                Console.WriteLine("I'm in the same assembly, but I'm not a derived class. I only can see private members using Reflection: " + valor);

                FieldInfo campoPrivateProtected = tipo.GetField("Private_Protected_Member_In_Another_Assembly", BindingFlags.NonPublic | BindingFlags.Instance);
                valor = (string)campoPrivateProtected.GetValue(neighbor_parent);
                Console.WriteLine("I'm in the same assembly, but I'm not a derived class. I olny can see private Protected members using Reflection: " + valor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"I'm in the same assembly, but I'm not a derived class. I have no problem to speak with internal members: {neighbor_parent.Internal_Member_In_Another_Assembly}");
            Console.WriteLine($"I'm in the same assembly, but I'm not a derived class. I have no problem to speak with protected internal members: {neighbor_parent.Protected_Internal_Member_In_Another_Assembly}");
            
            
        }
    }
}
