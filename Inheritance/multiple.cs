using System;
class multiple
{


    interface A
    {
        void add();

    }

    interface B
    {
        void Sub();

    }
    class C : A, B
    {
        public void add()
        {
            int a = 20; int b = 10;
            Console.WriteLine(a + b);

        }
        public void Sub()
        {
            int a = 20; int b = 10;
            Console.WriteLine(a - b);

        }
    }

    // Main Method
    public static void Main(String[] args)
    {
        C objC = new C();
        objC.add();
        objC.Sub();


        Console.ReadLine();
    }
}
