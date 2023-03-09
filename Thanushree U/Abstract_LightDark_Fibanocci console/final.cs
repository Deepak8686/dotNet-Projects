
using Abstract_LightDark_Themes.Concrete_Theme_Factories;
using Abstract_LightDark_Themes.FactoryItems;
using Abstract_LightDark_Themes.Theme_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LightDark_Themes
{
    public class final
    {
        private bool check;

        public void Choice()
        {
            IThemeFactory LightFactory = new LightThemeFactory();
            IButton lightButton = LightFactory.CreateButton();
            ILabel lightLabel = LightFactory.CreateLabel();
            ITextBox lightTextBox = LightFactory.CreateTextBox();

            IThemeFactory darkFactory = new DarkThemeFactory();
            IButton darkButton = darkFactory.CreateButton();
            ILabel darkLabel = darkFactory.CreateLabel();
            ITextBox darkTextBox = darkFactory.CreateTextBox();

            do
            {
                char tchoice;
                int n;
                Console.WriteLine("\n\nChoose D for Dark Theme\n ");
                Console.WriteLine("Choose L for Light Theme \n\n");
                tchoice = char.ToUpper(Console.ReadKey().KeyChar);
                
                IThemeFactory factory;
                switch (tchoice)
                {
                    case 'D':
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        darkButton.getTheme();
                        darkLabel.getTheme();
                        darkTextBox.getTheme();
                        Console.WriteLine("Enter number of Fibonacci series you want to generate\n");
                        n = Convert.ToInt32(Console.ReadLine());
                        factory = new DarkThemeFactory();
                        for (int i = 0; i <= n; i++)
                        {
                            int fib = Fibonacci.Calculate(i, factory);
                            Console.WriteLine($"\nFibonacci({i}) = {fib}\n");
                        }
                        
                        break;

                    case 'L':
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        lightButton.getTheme();
                        lightLabel.getTheme();
                        lightTextBox.getTheme();
                        factory = new LightThemeFactory();
                        Console.WriteLine("Enter number of Fibonacci series you want to generate\n");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i<=n; i++)
                        {
                            int fib = Fibonacci.Calculate(i, factory);
                            Console.WriteLine($"\nFibonacci({i}) = {fib} \n");
                        }
                        
                        break;
                    default:
                        Console.WriteLine("\n\nInvalid choice\n");
                        check = false;
                        break;
                }                  
            } while (check == false);
        }
        public static class Fibonacci
        {
            public static int Calculate(int n, IThemeFactory factory)
            {
                IButton button=factory.CreateButton();
                ILabel label = factory.CreateLabel();
                ITextBox textBox = factory.CreateTextBox();              


                if (n == 0)
                {
                    return 0;
                }
                else if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return Calculate(n - 1, factory) + Calculate(n - 2, factory);
                }

            }


            
        }
        
        
    }
}
