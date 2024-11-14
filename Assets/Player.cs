using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : character1
{
    public Player(string charactername, int health) : base(charactername, health)
    {
    }
    public void Heal(int amount)
    {
        int newHealth = Health + amount;
        if (newHealth > 100)
        {
            newHealth = 100;
        }
        Health = newHealth;
    }

}
