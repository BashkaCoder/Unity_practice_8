using System;
using System.Collections.Generic;
using Q3Movement;
using Q3Movement.Interfaces;

public class Inventory : IInventory
{
    public event Action<int> ItemAmountChanged;
    
    private readonly List<Item> _items = new();

    public void Add(Item item)
    {
        _items.Add(item);
        ItemAmountChanged?.Invoke(_items.Count);
    }

    public void Remove(Item item)
    {
        _items.Remove(item);
        ItemAmountChanged?.Invoke(_items.Count);
    }

    public void Remove(int index)
    {
        if (index < 0 || index >= _items.Count)
        {
            throw new ArgumentOutOfRangeException();
        }

        _items.RemoveAt(index);
        ItemAmountChanged?.Invoke(_items.Count);
    }
}