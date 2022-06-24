using System.Net.Sockets;

namespace ConsoleApplication3
{
    public readonly struct MenuOptions
    {
        private const string AddNewClient = "Dodaj nowego klienta";
        private const string DeleteClient = "Usuń klienta";
        private const string ShowClients = "Pokaż klientów";
        private const string Exit = "Wyjdź";

        public string[] GetMenuOptionsArr()
        {
            string[] menuOptions = { AddNewClient, DeleteClient, ShowClients, Exit };
            
            return menuOptions;
        }
    }
}