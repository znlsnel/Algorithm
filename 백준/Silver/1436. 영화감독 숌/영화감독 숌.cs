namespace Alroghtim_CS
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());
			int count = 0;
			int number = 665; // 666부터 시작하기 위해 665로 초기화

			while (count < N)
			{
				number++;
				if (number.ToString().Contains("666"))
				{
					count++;
				}
			}

			Console.WriteLine(number);
		}
	}
}
