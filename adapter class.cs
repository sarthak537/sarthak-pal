using System;
class P
{
    public virtual void Show()
    { 
        Console.WriteLine("helo");
    }
}
class C : P {
    public override void Show()
    {
        Console.WriteLine("hii");
    }
    static void Main()
    {
        P p = new C();
        p.Show();
    }
}