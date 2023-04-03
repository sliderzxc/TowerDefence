namespace Utils.Event
{
    public interface IEventListener<T>
    {
        void OnNotify(T value);
    }
}