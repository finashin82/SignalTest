using UnityEngine;
using Zenject;

public class ButtonScript : MonoBehaviour
{
    [Inject] private SignalBus _signalBus;

    public void OnButtonClick()
    {
        // ���������� ������ ��� �����
        _signalBus.Fire(new ButtonClickedSignal { ButtonName = "MainButton" });
    }
}
