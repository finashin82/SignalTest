using UnityEngine;
using Zenject;

public class Enemy
{
    public Enemy(SignalBus signalBus)
    {
        // ������������� �� ������
        signalBus.Subscribe<PlayerAttackSignal>(OnPlayerAttack);
    }

    private void OnPlayerAttack()
    {
        // ������� �� ����� ������
        Debug.Log("Enemy reacts to player's attack!");
    }
}