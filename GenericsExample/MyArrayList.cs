using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExample
{
	public class MyArrayList<T> : IMyList<T> where T : List
	{
		private const int DefaultListCapacity = 10;
		private T[] _array;
		public int Count { get; private set; }
		public int Capacity { get { return _array.Length; } }

		public MyArrayList(int capacity)
		{
			if (capacity <= 0)
			{
				throw new ArgumentOutOfRangeException("ArrayList is full!");
			}

			this._array = new T[capacity];
			this.Count = 0;
		}

		public MyArrayList() : this(DefaultListCapacity) { }

		public void Add(T element)
		{
			if (this.Count == this.Capacity)
			{
				T[] newArray = new T[this.Capacity * 2];

				this._array.CopyTo(newArray, 0);
				this._array = newArray;
			}

			this._array[Count] = element;
			this.Count++;
		}

		public bool Remove(T element)
		{
			for (int i = 0; i < this.Count; i++)
			{
				if ((this._array[i] != null && this._array[i].Equals(element)) //avoid null reference exception with check
				  || (this._array[i] == null && element == null)) //handle the case where the element is actually null
				{
					this.ShiftArray(i);

					return true;
				}
			}

			return false;
		}

		public void RemoveAt(int index)
		{
			this.CheckIndex(index);

			this.ShiftArray(index);
		}

		public string GetElement(int index)
		{
			this.CheckIndex(index);

			return this._array[index].ListName;
		}

		public void ReplaceElement(int index, T element)
		{
			this.CheckIndex(index);

			this._array[index] = element;
		}

		private void ShiftArray(int startIndex)
		{
			int index = startIndex;

			while (index < this.Count - 1)
			{
				this._array[index] = this._array[index + 1];

				index++;
			}

			this.Count--;
			this._array[this.Count] = default(T);
		}

		private void CheckIndex(int index)
		{
			if (index < 0 || index >= this.Count)
			{
				throw new IndexOutOfRangeException();
			}
		}
	}
}
