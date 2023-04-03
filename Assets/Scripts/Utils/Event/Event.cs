using System.Collections.Generic;

namespace Utils.Event
{
    public class Event<T>
    {
        private List<IEventListener<T>> listeners = new();

        public void Invoke(T value)
        {
            foreach (var listener in listeners) {
                listener.OnNotify(value);
            }
        }

        public void AddListener(IEventListener<T> listener)
        {
            listeners.Add(listener);
        }

        public void RemoveListener(IEventListener<T> listener)
        {
            listeners.Remove(listener);
        }
    }
}