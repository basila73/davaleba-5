namespace davaleba_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            {
                int[] transactions = { 120, -50, 300, -100, 80, -200, 500, -30, 150, -400 };

                int depositCount = 0;
                int withdrawCount = 0;
                int depositSum = 0;
                int withdrawSum = 0;

                for (int i = 0; i < transactions.Length; i++)
                {
                    if (transactions[i] > 0)
                    {
                        Console.WriteLine("shetana: " + transactions[i] + " lari");
                        depositCount++;
                        depositSum += transactions[i];
                    }
                    else
                    {
                        Console.WriteLine("gatana: " + (-transactions[i]) + " lari");
                        withdrawCount++;
                        withdrawSum += -transactions[i];
                    }
                }

                int balance = depositSum - withdrawSum;

                Console.WriteLine("shetanis raodenoba: " + depositCount);
                Console.WriteLine("gatanis raodenoba: " + withdrawCount);
                Console.WriteLine("shetanii tanxa: " + depositSum);
                Console.WriteLine("gatanili tanxa: " + withdrawSum);
                Console.WriteLine("saboloo tanxa: " + balance);

                if (balance > 0)
                    Console.WriteLine("angarishze tanxaa");
                else if (balance < 0)
                    Console.WriteLine("angarishi minushia");
                else
                    Console.WriteLine("angarishis balansi nulia");
            }
        }

    }

}
