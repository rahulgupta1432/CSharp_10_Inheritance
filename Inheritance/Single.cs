using System;
class Single
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

    // Main Method
    public static void Main(String[] args)
    {
        B ObjB = new B();
        ObjB.hii();
        ObjB.hello();
        Console.ReadLine();
    }
}
