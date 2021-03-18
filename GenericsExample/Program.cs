using System;

namespace GenericsExample
{
	public class Program
	{
		public static void Main(string[] args)
		{
			MyArrayList<List> firstList = new MyArrayList<List>(5);

			List supportList = new List("List 1", 1);
			List supportList2 = new List("List 2", 2);
			List supportList3 = new List("List 3", 3);
			List supportList4 = new List("List 4", 4);
			List supportList5 = new List("List 5", 5);
			List supportList6 = new List("List 6", 6);

			firstList.Add(supportList);
			firstList.Add(supportList2);
			firstList.Add(supportList3);
			firstList.Add(supportList4);
			firstList.Add(supportList5);
			firstList.Add(supportList6);

			firstList.Remove(supportList);

			firstList.ReplaceElement(1, supportList4);

			Console.WriteLine("Capacity: " + firstList.Capacity);

			Console.WriteLine("Array: ");

			for (int i = 0; i < firstList.Count; i++)
			{
				Console.WriteLine(firstList.GetElement(i));
			}


			Console.ReadKey();
		}
	}
}
