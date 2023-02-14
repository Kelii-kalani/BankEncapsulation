namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine("How much mullah wouuld you like to deposit?");
            var userDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(userDeposit);

            double userBalance = ba.GetBalance();

            Console.WriteLine($"Your balance is: {userBalance, 0:c}");

        }
    }
}
