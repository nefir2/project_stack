using stack_kateassy.Classes;

using System;

namespace stack_kateassy
{
	internal class Program
	{
		private static void Main()
		{
			Random rnd = new Random();

			SimpleStack simst = new SimpleStack(new int[] { 1, 2, 3 });
			Console.WriteLine("new stack: " + simst);

			simst.Push(rnd.Next(10));
			Console.WriteLine("stack with new element: " + simst);
			Console.WriteLine($"stack size: {simst.Size()}");

			Console.Write("stack pop: ");
			while (!simst.IsEmpty()) Console.Write(simst.Pop() + " ");
			Console.WriteLine($"\nstack size: {simst.Size()}");

			Console.Write("random stack: ");
			for (int i = 0; i < 10; i++) simst.Push(rnd.Next(0, 100));
			Console.WriteLine(simst);

			Console.Write("reverse stack: ");
			simst = SimpleStack.CreateStack(simst) as SimpleStack ?? new SimpleStack();
			Console.WriteLine(simst);

			Console.WriteLine("\t\tstack clear");
			simst.Clear();
			Console.WriteLine($"stack size: {simst.Size()}");
		}
	}
}