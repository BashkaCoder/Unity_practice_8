using System;

namespace Q3Movement.Interfaces
{
    public interface IInventory
    {
        public event Action<int> ItemAmountChanged;
        
        public void Add(Item item);
        public void Remove(Item item);
        public void Remove(int index);
    }
}