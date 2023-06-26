using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ClassB
    {        
        public string Message { get; set; }
        public ClassB(string message)
        {
            Message = message;
            Console.WriteLine(message);
        }
    }

    public class ClassD:ClassB
    {
        public ClassD(string message) :base("Drive")
        {
            Console.WriteLine(message);
        }
    }

    #region Call base class virtual method
    public class BaseClass
    {
        public virtual void Method()
        {
            Console.WriteLine("I am a base class method.");
        }
    }
    public class DerivedClass : BaseClass
    {
        public new void Method()
        {
            Console.WriteLine("I am a child class method.");
        }
    }
    #endregion

    #region Force implement Virtual method
    public class ClassB1
    {
        public virtual void Method()
        {
            // Original Implementation.
        }
    }

    public abstract class AbstractClass : ClassB1
    {
        public abstract override void Method();
    }

    public class NonAbstractChildClass : AbstractClass
    {
        public void Sum(int FirstNumber, int SecondNumber)
        {
            int Result = FirstNumber + SecondNumber;
        }

        public int Sum(int FirstNumber, int SecondNumber,int ThirdNumber)
        {
            return FirstNumber + SecondNumber;
        }

        public override void Method()
        {
            // New implementation.
        }
    }
    #endregion

    public struct TestStruct
    {
        public TestStruct(int n)
        {
            MyProperty = n;
        }
        public int MyProperty { get; set; } = 20;
        //public int i = 10;
        //Error: cannot have instance field initializers in structs
    }

}
