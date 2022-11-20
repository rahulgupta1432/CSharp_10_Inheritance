using System;
class multilevel
{
    class A
    {
        public void hii()
        {
            Console.WriteLine("from class A ,hii");
        }
    }

    class B : A
    {
        public void hello()
        {
            Console.WriteLine("from class B ,hello");
        }
    }
    class C : B
    {
        public void GOODMORNING()
        {
            Console.WriteLine("from class C ,Good Morning");
        }
    }

    // Main Method
    public static void Main(String[] args)
    {
        C ObjC = new C();
        ObjC.hii();
        ObjC.hello();
        ObjC.GOODMORNING();
        Console.ReadLine();
    }
}
