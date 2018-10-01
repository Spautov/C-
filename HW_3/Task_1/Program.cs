using BankSystem;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank SberBank = new Bank();
            Terminal.ShowMainMenu(ref SberBank);
        }
       
    }
}
