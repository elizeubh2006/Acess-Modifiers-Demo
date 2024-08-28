using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AnotherAssembly;

namespace Acess_Modifiers_Demo
{
    //I'm not covering public members. It is just the most permissive member in or out the assembly
    public class Derived_Class_A : Parent_Class_In_Another_Assembly
    {
        public void Chat_With_Neighboring_Classes()
        {
            Parent_Class_In_Another_Assembly neighbor_parent = new Parent_Class_In_Another_Assembly();

            try //trying to speak with a hide members
            {
                Type tipo = neighbor_parent.GetType(); //Get in touch with a hide member

                FieldInfo campoPrivate = tipo.GetField("PrivateMember", BindingFlags.NonPublic | BindingFlags.Instance);
                string valor = (string)campoPrivate.GetValue(neighbor_parent);
                Console.WriteLine("I'm in a differente assembly, and I AM a derived class. I only can see private members using Reflection: " + valor);

                FieldInfo campoPrivateProtected = tipo.GetField("Private_Protected_Member_In_Another_Assembly", BindingFlags.NonPublic | BindingFlags.Instance);
                valor = (string)campoPrivate.GetValue(neighbor_parent);
                Console.WriteLine("I'm in a differente assembly, and I AM a derived class. I olny can see private Protected members using Reflection: " + valor);

                FieldInfo campoInternal = tipo.GetField("Internal_Member_In_Another_Assembly", BindingFlags.NonPublic | BindingFlags.Instance);
                valor = (string)campoPrivate.GetValue(neighbor_parent);
                Console.WriteLine("I'm in a differente assembly, and I AM a derived class. I olny can see Internal members using Reflection: " + valor);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"I'm in a different assembly, and I AM a derived class. I have no problem to speak with protected members: {this.Protected_Member_In_Another_Assembly}");
            Console.WriteLine($"I'm in a different assembly, and I AM a derived class. I have no problem to speak with protected internal members: {this.Protected_Internal_Member_In_Another_Assembly}");
            
        }
    }
}
