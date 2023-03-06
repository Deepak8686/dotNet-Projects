
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
                Console.WriteLine("\n\nChoose D for Dark Theme\n ");
                Console.WriteLine("Choose L for Light Theme \n\n");
                tchoice = char.ToUpper(Console.ReadKey().KeyChar);
                IThemeFactory factory;
                switch (tchoice)
                {
                    case 'D':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        darkButton.getTheme();
                        darkLabel.getTheme();
                        darkTextBox.getTheme();
                        factory = new DarkThemeFactory();
                        for (int i = 0; i < 10; i++)
                        {
                            int fib = Fibonacci.Calculate(i, factory);
                            Console.WriteLine($"Fibonacci({i}) = {fib}\n");
                        }
                        
                        break;

                    case 'L':
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        lightButton.getTheme();
                        lightLabel.getTheme();
                        lightTextBox.getTheme();
                        factory = new LightThemeFactory();
                        for (int i = 0; i < 10; i++)
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
