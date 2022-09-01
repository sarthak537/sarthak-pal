class Test
{
    private Test() { }
    public void Show()
    {
        System.Console.WriteLine("hello");
    }
    public static Test GetTestobjet()
    {
        Test test = new Test();
        return test;
    }

}
class Demo
{
    static void Main()
    {
        Test t = Test.GetTestobjet();
        t.Show();
    }
}
