using stack_kateassy.Classes;
using stack_kateassy.Interfaces;

namespace stack_kateassy
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			SimpleStack simst = new SimpleStack(new int[] { 1, 2, 3 });
			Console.WriteLine("new stack: " + simst);
			simst.Push(1);
			Console.WriteLine("stack with new element: " + simst);
			Console.WriteLine($"stack size: {simst.Size()}");

			Console.Write("stack pop: ");
			while (!simst.IsEmpty()) Console.Write(simst.Pop() + " ");
			Console.WriteLine($"\nstack size: {simst.Size()}");

			Console.Write("random stack: ");
			Random rnd = new Random();
			for (int i = 0; i < 10; i++) simst.Push(rnd.Next(0, 100));
			Console.WriteLine(simst);

			Console.Write("reverse stack: ");
			simst = CreateStack(simst) as SimpleStack ?? new SimpleStack();
			Console.WriteLine(simst);

			Console.WriteLine("\t\tstack clear");
			simst.Clear();
			Console.WriteLine($"stack size: {simst.Size()}");

		}
		public static IStack CreateStack(Stack<int> s) => new SimpleStack(s.Reverse().ToList<int>());
		public static IStack CreateStack(IStack s)
		{
			SimpleStack newStack = new SimpleStack();
			int sSize = s.Size();
			for (int i = 0; i < sSize; i++) newStack.Push(s.Pop());
			return newStack;
		}
		public static IStack CreateStack(SimpleStack s)
		{
			s.Reverse();
			return new SimpleStack(s);
		}
	}
}