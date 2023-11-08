using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var class1 = Type.GetTypeFromCLSID(new Guid("1886d7fa-4ec6-4c40-945c-429bfdd9e407"));
            var class1_inst = Activator.CreateInstance(class1);
            Console.WriteLine("Loaded class 1");

            var class2 = Type.GetTypeFromCLSID(new Guid("7cceb258-a1f3-4c66-8998-d360a791042c"));
            var class2_inst = Activator.CreateInstance(class2);
            Console.WriteLine("Loaded class 2");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
