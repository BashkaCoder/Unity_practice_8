using Q3Movement.Interfaces;
using UnityEngine;
using Zenject;

[RequireComponent(typeof(SphereCollider))]
public class InteractFeature : MonoBehaviour
{
    private IInventory _inventory;

    [Inject]
    public void Construct(IInventory inventory)
    {
        _inventory = inventory;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out IInteractable interactable))
        { 
            interactable.React(_inventory);
        }
    }
}