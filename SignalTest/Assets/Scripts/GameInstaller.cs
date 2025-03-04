using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller<GameInstaller>
{
    public override void InstallBindings()
    {
        // ������������� ������
        SignalBusInstaller.Install(Container);

        // ������������ ������
        Container.DeclareSignal<ButtonClickedSignal>();

        // ������������ ButtonScript � ReceiverScript
        Container.Bind<ButtonScript>().AsSingle();
        Container.Bind<ReceiverScript>().AsSingle();
    }
}