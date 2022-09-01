using System;

interface I1
{
     void M1();
    void M2();
}
class Demo : I1
{
    public void M1()
    {
        System.Console.WriteLine(" hello");
    }
    public void M2()
    {
        System.Console.WriteLine(" hi");
    }
    static void Main()
    {
        I1 obj = new Demo();
        obj.M1();
        obj.M2();


    }

}