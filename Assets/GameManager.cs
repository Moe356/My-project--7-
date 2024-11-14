using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("Subhi", 80);
        Enemy enemy = new Enemy("Zarifeh", 100);
        Debug.Log("Player Name: " + player.charactername + ", Health: " + player.Health);
        Debug.Log("Enemy Name: " + enemy.charactername + ", Health: " + enemy.Health);
        
    }

}
