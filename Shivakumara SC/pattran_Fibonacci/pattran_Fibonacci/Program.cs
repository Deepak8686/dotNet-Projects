using pattran_Fibonacci;

class Main_Class
{
    static void Main(string[] args)
    {
        InputFibonacci inputFibonacci = new InputFibonacci();
        Fabonacci_Cal Calculor  =  new Fabonacci_Cal(inputFibonacci);

        Calculor.Fabonacci_Cal1();
        Console.WriteLine("\n");
    }
}