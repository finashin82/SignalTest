using UnityEngine;
using Zenject;

public class ButtonScript : MonoBehaviour
{
    [Inject] private SignalBus _signalBus;

    public void OnButtonClick()
    {
        // Отправляем сигнал при клике
        _signalBus.Fire(new ButtonClickedSignal { ButtonName = "MainButton" });
    }
}
