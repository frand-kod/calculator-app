class Calculator
{
	static void Main(string[] args)
	{
		int a=2,b=2;
		Console.WriteLine("hasil penambahan " + a + "+" + b + " = " + Penambahan(a, b));
		Console.WriteLine("hasil pengurangan " + a + "-" + b + " = " + Pengurangan(a, b));
	}
	static init Penambahan (int a, int b);
	{
		return a+b;
	}
	static init Pengurangan (int a, int b);
	{
		return a-b;
	}
}