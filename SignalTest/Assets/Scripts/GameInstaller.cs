using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller<GameInstaller>
{
    public override void InstallBindings()
    {
        // Устанавливаем сигнал
        SignalBusInstaller.Install(Container);

        // Регистрируем сигнал
        Container.DeclareSignal<ButtonClickedSignal>();

        // Регистрируем ButtonScript и ReceiverScript
        Container.Bind<ButtonScript>().AsSingle();
        Container.Bind<ReceiverScript>().AsSingle();
    }
}