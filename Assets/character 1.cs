using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class character1 : MonoBehaviour
{
    public string charactername;
    public int health;

    public string Charactername
    {
        get { return charactername; }
        set{charactername = value;}


    }
    public int Health
    {
        get {return health;}
        set{if (value < 0)
            {
                health = 0;
            }
            else if (value > 100)
            {
                health = 100;
            }
            else
            {
                health = value;
            }
            }

    }
        public character1 (string charactername, int health)
    {
        Charactername = charactername;
        Health = health;
    }


}
