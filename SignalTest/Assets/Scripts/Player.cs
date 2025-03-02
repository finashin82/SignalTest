using UnityEngine;
using Zenject;

public class Player
{
    private readonly SignalBus _signalBus;

    public Player(SignalBus signalBus)
    {
        _signalBus = signalBus;
    }

    public void Attack()
    {
        // ������ �����
        Debug.Log("Player attacks!");

        // ���������� ������
        _signalBus.Fire<PlayerAttackSignal>();
    }
}