using System;

namespace stack_kateassy.Interfaces
{
	public interface IStack
	{
		/// <summary>
		/// adds new <paramref name="value"/> to stack.
		/// </summary>
		/// <param name="value">value, to add to stack.</param>
		void Push(int value);
		/// <summary>
		/// gets last element from stack.
		/// </summary>
		/// <returns>last element.</returns>
		int Pop();
		/// <summary>
		/// value that shows is empty stack or not.
		/// </summary>
		/// <returns><see langword="true"/> if is empty, else <see langword="false"/>.</returns>
		Boolean IsEmpty();
		/// <summary>
		/// returns size of Stack.
		/// </summary>
		/// <returns>size of Stack.</returns>
		int Size();
		/// <summary>
		/// clears Stack.
		/// </summary>
		void Clear();
	}
}