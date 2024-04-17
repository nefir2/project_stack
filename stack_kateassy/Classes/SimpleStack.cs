using stack_kateassy.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;

namespace stack_kateassy.Classes
{
	public class SimpleStack : IStack, ICloneable
	{
		private List<int> stack;
		public SimpleStack() => stack = new List<int>();
		public SimpleStack(int[] stack) : this(stack.ToList<int>()) { }
		public SimpleStack(List<int> stack)
		{
			stack ??= new List<int>();
			this.stack = new List<int>(stack.Count);
			for (int i = 0; i < stack.Count; i++) this.stack.Add(stack[i]);
		}
		public SimpleStack(Stack<int> stack) : this(stack.ToList<int>()) { }
		public SimpleStack(SimpleStack stack) : this(stack.AsList()) { }
		public void Clear() => stack.Clear();
		public bool IsEmpty() => stack.Count == 0;
		public int Pop()
		{
			if (this.IsEmpty()) return 0;
			int value = stack[^1];
			stack.RemoveAt(stack.Count - 1);
			return value;
		}
		public void Push(int value) => stack.Add(value);
		public int Size() => stack.Count;
		private void Reverse() => stack.Reverse();
		private List<int> AsList() => stack;
		public object Clone() => new SimpleStack(stack.ToList<int>());
		internal static SimpleStack Reverse(SimpleStack s) => (CreateStack(s) as SimpleStack) ?? new SimpleStack(s);
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
		public override string ToString()
		{
			string ret = "";
			stack.Reverse();
			for (int i = 0; i < stack.Count; i++) ret += stack[i] + " "; //начиная с вершины - это с конца?
			stack.Reverse();
			return ret;
		}
	}
}