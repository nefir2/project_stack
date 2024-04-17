using System;
using System.Collections.Generic;
using System.Linq;

using stack_kateassy.Interfaces;

namespace stack_kateassy.Classes
{
	public class SimpleStack : IStack, ICloneable
	{
		private List<int> stack;
		public SimpleStack() => stack = new List<int>();
		public SimpleStack(int[] stack) : this(stack.ToList<int>()) { } // => this.stack = stack.ToList<int>();
		public SimpleStack(List<int> stack)
		{
			this.stack = new List<int>(stack.Count);
			for (int i = 0; i < stack.Count; i++) this.stack.Add(stack[i]);
		}
		public SimpleStack(Stack<int> stack) : this(stack.ToList<int>()) { } // => this.stack = stack.ToList<int>();
		public SimpleStack(SimpleStack stack) : this(stack.AsList()) { } // => this.stack = new List<int>() { (stack.Clone() as SimpleStack) };
		public void Clear() => stack.Clear();
		public bool IsEmpty() => stack.Count == 0;
		public int Pop()
		{
			if (this.IsEmpty()) return 0;
			int value = stack.Last();
			stack.RemoveAt(stack.Count - 1);
			return value;
		}
		public void Push(int value) => stack.Add(value);
		public int Size() => stack.Count;
		internal void Reverse() => stack.Reverse();
		public override string ToString()
		{
			string ret = "";
			stack.Reverse();
			for (int i = 0; i < stack.Count; i++) ret += stack[i] + " "; //начиная с вершины - это с конца?
			stack.Reverse();
			return ret;
		}
		private List<int> AsList() => stack;
		public object Clone() => new SimpleStack(stack.ToList<int>());
	}
}