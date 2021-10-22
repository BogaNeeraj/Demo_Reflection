using System;
using System.Reflection;



namespace Demo_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Reflection in c#...");
            Type T = typeof(int);
            Console.WriteLine("Type of Name:{0}", T.Name);
            Console.WriteLine("Full name of the type defined :\t{0}", T.FullName);
            Console.WriteLine("Type of Assembly in which it is defined :\t {0} ", T.Assembly);
            Console.WriteLine("Information about base Type:\t{0}\n", T.BaseType);



            Type T1 = typeof(string);
            Console.WriteLine("Type of Name:{0}", T1.Name);
            Console.WriteLine("Full name of the type defined :\t{0}", T1.FullName);
            Console.WriteLine("Type of Assembly in which it is defined :\t {0} ", T1.Assembly);
            Console.WriteLine("Information about base Type:\t{0}\n", T1.BaseType);

            Dynamic_Object MyObj1 = new Dynamic_Object();
            MyObj1.First_Method();
            MyObj1.Second_Method();


            Dynamic_Object MyObj2 = new Dynamic_Object();
            MyObj2.First_Method();
            MyObj2.Second_Method();



           
        }

    }
}
