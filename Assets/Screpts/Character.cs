using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string name = "Omar";
    private int health = 100;
    public int Health
    {
        get { return health; }
        set
        {
            if (value > 100) health = 100;
            else if (value >= 0 && value <= 100) health = value;
            else if (value < 0) health = 0;
        }
    }
    public string Name
    {
        get { return name; }
        set{ name = value; }
    }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

}
