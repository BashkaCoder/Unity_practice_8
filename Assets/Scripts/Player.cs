using Q3Movement.Interfaces;
using UnityEngine;
using Zenject;

public class Player : MonoBehaviour
{
    private IInventory _currentInventory;
    private InteractFeature _interactFeature;

    [Inject]
    public void Construct(IInventory inventory, InteractFeature interactFeature)
    {
        _currentInventory = inventory;
        _interactFeature = interactFeature;
    }
}