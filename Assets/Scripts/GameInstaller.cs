using Q3Movement;
using Q3Movement.Interfaces;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private Player _player;
    [SerializeField] private InteractFeature _interactFeature;
    [SerializeField] private InventoryView _inventoryView;
    
    public override void InstallBindings()
    {
        Container.Bind<IInventory>().To<Inventory>().AsSingle();
        
        Container.Bind<Player>().FromInstance(_player).AsSingle();
        Container.Bind<InteractFeature>().FromInstance(_interactFeature).AsSingle();
        Container.Bind<InventoryView>().FromInstance(_inventoryView).AsSingle();
    }
}