namespace AnotherAssembly
{
    public class Parent_Class_In_Another_Assembly
    {
        //I'm not covering public members. It is just the most permissive member in or out the assembly
        private string PrivateMember = "I'm a private member from another assembly";
        protected string Protected_Member_In_Another_Assembly = "I'm a protected member from another assembly";
        internal string Internal_Member_In_Another_Assembly = "I'm an internal member from another assembly";
        protected internal string Protected_Internal_Member_In_Another_Assembly = "I'm a protected internal member from another assembly";
        private protected  string Private_Protected_Member_In_Another_Assembly = "I'm a private protected member from another assembly";


    }
}
