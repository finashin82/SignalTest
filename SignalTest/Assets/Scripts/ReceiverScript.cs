using UnityEngine;
using Zenject;

public class ReceiverScript : MonoBehaviour
{
    [Inject] private SignalBus _signalBus;

    private void Start()
    {
        // Подписываемся на сигнал
        _signalBus.Subscribe<ButtonClickedSignal>(OnButtonClicked);
    }

    private void OnDestroy()
    {
        // Отписываемся при уничтожении объекта
        _signalBus.Unsubscribe<ButtonClickedSignal>(OnButtonClicked);
    }

    private void OnButtonClicked(ButtonClickedSignal signal)
    {
        Debug.Log($"Кнопка {signal.ButtonName} была нажата!");
    }
}
