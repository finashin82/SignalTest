using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        // ������������ ������
        Container.DeclareSignal<PlayerAttackSignal>();

        // ������������ Player � Enemy
        Container.Bind<Player>().AsSingle();
        Container.Bind<Enemy>().AsSingle();
    }
}