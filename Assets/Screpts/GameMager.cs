using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMager : MonoBehaviour
{

    Player player;
    Enemy enemy;
    void Start()
    {
        player = new Player("Omar", 90);
        enemy = new Enemy("BadEnamy", 70);

        Debug.Log(player.Name);
        Debug.Log(player.Health);

        Debug.Log(enemy.Name);
        Debug.Log(enemy.Health);

        player.Heal(15);
        Debug.Log(player.Health);

        enemy.Attack(player,25);
        Debug.Log(player.Health);

    }

}
