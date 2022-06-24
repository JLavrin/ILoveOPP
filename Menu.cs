using System;

namespace ConsoleApplication3
{
    public class Menu
    {
        private static readonly MessagesColors MessagesColors = new MessagesColors();
        public int Init()
        {
            const string errorMessage = "Błędna opcja. Spróbuj ponownie.";
            const string menuStartMessage = "Wybierz opcję:";
            
            MessagesColors.Info(menuStartMessage);
            
            while (true)
            {
                
                ShowMenu();
                Console.Write(">");
                var chosenOption = InputHandler();
                if (chosenOption != -1)
                {
                    return chosenOption;
                }
                Clear();
                MessagesColors.Error(errorMessage);
            }
        }
        
        private static void ShowMenu()
        {
            var menuOptions = new MenuOptions();
            var menuOptionsArray = menuOptions.GetMenuOptionsArr();
            for (var index = 0; index < menuOptionsArray.Length; index++)
            {
                GenerateRow(index, menuOptionsArray[index]);
            }
        }

        private static int InputHandler()
        {
            var input = Console.ReadLine();
            if (input == null || !IsValueCorrect(input))
            {
                return -1;
            }

            return int.Parse(input);
        }

        private static bool IsValueCorrect(string value)
        {
            var menuOptions = new MenuOptions();
            var arrLength = menuOptions.GetMenuOptionsArr().Length;

            try
            {
                var index = int.Parse(value);

                if (index < 0 || index > arrLength - 1)
                    return false;
            }

            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        private static void GenerateRow(int index, string text)
        {
            Console.WriteLine(++index + ". " + text);
        }

        private void Clear()
        {
            Console.Clear();
        }
    }
}