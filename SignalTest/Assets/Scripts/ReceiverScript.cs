using UnityEngine;
using Zenject;

public class ReceiverScript : MonoBehaviour
{
    [Inject] private SignalBus _signalBus;

    private void Start()
    {
        // ������������� �� ������
        _signalBus.Subscribe<ButtonClickedSignal>(OnButtonClicked);
    }

    private void OnDestroy()
    {
        // ������������ ��� ����������� �������
        _signalBus.Unsubscribe<ButtonClickedSignal>(OnButtonClicked);
    }

    private void OnButtonClicked(ButtonClickedSignal signal)
    {
        Debug.Log($"������ {signal.ButtonName} ���� ������!");
    }
}
