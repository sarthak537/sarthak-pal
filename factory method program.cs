class Test
{
    private Test() { }
    private static Test test;

    public void show()
    {
        System.Console.WriteLine("hello " + this.GetHashCode());
    }
    public static Test GetTestobject()
    {
        if (test == null)
        {
            test = new Test();
        }
        return test;
    }
}
class Demo
{
    static void Main1()
    {
        Test t = Test.GetTestobject();
        t.show();
        Test t1 = Test.GetTestobject();
        t1.show();
    }
}