namespace GenericsExample
{
    public interface IMyList<T>
    {
        int Count { get; }

        void Add(T element);

        bool Remove(T element);

        void RemoveAt(int index);

        string GetElement(int index);

        void ReplaceElement(int index, T element);
    }
}
