using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num2
{
    class Program
    {
        public static void ClassTaker (MyClass myClass)
        {
            myClass.changes = "changes";
            
        }
        public static void StructTaker(MyStruct myStruct)
        {
            myStruct.changes = "changes";
          
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.changes = "not changes";
            myStruct.changes = "not changes";

            Console.WriteLine (myClass.changes);
            Console.WriteLine (myStruct.changes);

            
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine(myClass.changes);
            Console.WriteLine(myStruct.changes);


            //структура не змінила значення після виклику методу бо це була тілки копія
        }


    }
}
