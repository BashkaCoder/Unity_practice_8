using Q3Movement.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Q3Movement
{
    public class InventoryView : MonoBehaviour
    {
        [SerializeField] private Text itemsAmountText;

        private IInventory _inventory;
        
        private void OnDisable()
        {
            _inventory.ItemAmountChanged -= OnItemAmountChanged;
        }

        [Inject]
        public void Construct(IInventory inventory)
        {
            _inventory = inventory;
            itemsAmountText.text = "x0";
            _inventory.ItemAmountChanged += OnItemAmountChanged;
        }
        
        private void OnItemAmountChanged(int itemsAmount)
        {
            itemsAmountText.text = "x" + itemsAmount;
        }
    }
}