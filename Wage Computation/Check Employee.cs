namespace Wage_Computation
{
    internal class Check_Employee
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int attendace = random.Next(0, 2);

            if (attendace == 1)
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");
            }
        }
    }
}
