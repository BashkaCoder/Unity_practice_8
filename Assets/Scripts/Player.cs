using System;
using System.Collections.Generic;
using UnityEngine;

namespace Q3Movement
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Q3PlayerController controller;

        #region Inventory
        private readonly List<Item> _items = new List<Item>();

        public void Add(Item item)
        {
            _items.Add(item);
        }

        public void Remove(Item item)
        {
            _items.Remove(item);
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= _items.Count)
            {
                throw new ArgumentException();
            }

            _items.RemoveAt(index);
        }
        #endregion
    }
}