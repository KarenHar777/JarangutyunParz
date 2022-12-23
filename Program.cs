
// See https://aka.ms/new-console-template for more information
class A
{
    public string name = "CAR";
    protected string name2 = "BMW";
}
class B : A
{
    public  void Print()
    { 
        Console.WriteLine(name);
        Console.WriteLine(name2);
    }
}
class C : B
{
  
}
class Program
{
    static void Main()
    {
        
        B b = new B();

        b.name = "Muk";
        // b.name2 stex chi erevum, qani vor Program classy jarangvac chi A class ic 

        b.Print();

        Console.ReadKey();

    }

}


