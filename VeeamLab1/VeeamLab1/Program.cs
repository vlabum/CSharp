using System;
using System.Runtime.InteropServices;

namespace VeeamLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyImmutable imm = new MyImmutable(1, "one");
            Console.WriteLine(imm);

            imm = imm.Clone(caption: "Один");
            Console.WriteLine(imm);

            IGetInfo bs = new Base();
            IGetInfo a = new A();

            Console.WriteLine(bs.GetInfo());
            Console.WriteLine(a.GetInfo());
        }
    }
}
