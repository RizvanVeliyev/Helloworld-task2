namespace hw
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("a:");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("b:");
			int b = Convert.ToInt32(Console.ReadLine());
			int balance;
			balance = a % b;
			Console.Write("qaliq:");
			Console.WriteLine(balance);

		}
	}
}