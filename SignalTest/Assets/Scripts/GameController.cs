using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour
{
    private Player _player;

    [Inject]
    public void Construct(Player player)
    {
        _player = player;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _player.Attack();
        }
    }
}