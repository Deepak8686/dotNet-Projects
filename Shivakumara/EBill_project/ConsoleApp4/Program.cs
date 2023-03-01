namespace ConsoleApp4
{
    public class Program 
    {
        static void Main(string[] args)
        {
            InputClass a = new InputClass();
            try
            {
                a.gettingdata();
            }
            catch (Exception)
            {
                Console.WriteLine("calling method is not exist");
            }
        }
    }
}
