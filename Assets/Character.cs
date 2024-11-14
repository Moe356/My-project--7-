using UnityEngine;

public class Character
{
    private string name = "Subhi";
    private int health;

    public Character(int health = 100)
    {
        Health = health; 
    }

    
    public string Name
    {
        get { return name; }
    }

    
    public int Health
    {
        get { return health; }
        set
        {
            if (value > 100)
            {
                health = 100;
            }
            else if (value < 0)
            {
                health = 0;
            }
            else
            {
                health = value;
            }
        }
    }
}
