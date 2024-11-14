using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : character1
{    public Enemy (string charactername, int health) : base(charactername, health)
    {
    }
        public void Attack(character1 target, int damage)
    {
        target.Health -= damage;
    }



}
