using System;

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
class C : A
{

    public void GOODMORNING()
    {

        Console.WriteLine("from class C ,Good Morning");

    }
}

class hierachical
{

    public static void Main(string[] args)
    {

        C ObjC = new C();

        ObjC.hii();


        ObjC.GOODMORNING();


        B ObjB = new B();

        ObjB.hello();

        ObjB.hii();


        A ObjA = new A();

        ObjA.hii();

    }

}
