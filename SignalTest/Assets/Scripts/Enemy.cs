using UnityEngine;
using Zenject;

public class Enemy
{
    public Enemy(SignalBus signalBus)
    {
        // Подписываемся на сигнал
        signalBus.Subscribe<PlayerAttackSignal>(OnPlayerAttack);
    }

    private void OnPlayerAttack()
    {
        // Реакция на атаку игрока
        Debug.Log("Enemy reacts to player's attack!");
    }
}