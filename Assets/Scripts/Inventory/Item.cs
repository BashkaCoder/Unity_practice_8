using Q3Movement.Interfaces;
using UnityEngine;

namespace Q3Movement
{
    [RequireComponent(typeof(SphereCollider))]
    public class Item : MonoBehaviour, IInteractable
    {
        [field: SerializeField] public string Name { get; private set; }

        public void React(IInventory inventory)
        {
            Debug.Log("Item added to Inventory");
            inventory.Add(this);
            Destroy(gameObject);
        }
    }
}