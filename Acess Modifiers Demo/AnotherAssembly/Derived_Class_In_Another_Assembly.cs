using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherAssembly
{
    public class Derived_Class_In_Another_Assembly : Parent_Class_In_Another_Assembly
    {
        public void Say_Hi_Protected_Member_In_Another_Assembly()
        {
            Console.WriteLine($"I AM a derived class in the same assembly. I have no problem to speak with internal members:{this.Internal_Member_In_Another_Assembly}");
            Console.WriteLine($"I AM a derived class in the same assembly. I have no problem to speak with protected members:{this.Protected_Member_In_Another_Assembly}");
            Console.WriteLine($"I AM a derived class in the same assembly. I have no problem to speak with private protected members:{this.Private_Protected_Member_In_Another_Assembly}");
            Console.WriteLine($"I AM a derived class in the same assembly. I have no problem to speak with protected internal members:{this.Protected_Internal_Member_In_Another_Assembly}");
            
        }
    }
}
