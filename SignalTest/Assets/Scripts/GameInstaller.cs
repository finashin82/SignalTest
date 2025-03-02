using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        // Регистрируем сигнал
        Container.DeclareSignal<PlayerAttackSignal>();

        // Регистрируем Player и Enemy
        Container.Bind<Player>().AsSingle();
        Container.Bind<Enemy>().AsSingle();
    }
}