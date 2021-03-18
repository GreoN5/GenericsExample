namespace GenericsExample
{
	public class List
	{
		public string ListName { get; private set; }
		public int ListNumber { get; private set; }

		public List(string name, int listNumber)
		{
			this.ListName = name;
			this.ListNumber = listNumber;
		}
	}
}
