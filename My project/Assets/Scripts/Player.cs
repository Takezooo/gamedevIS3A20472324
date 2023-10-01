using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    int _health;
    int mana;
    string name;

    //Constructor - must be the same name of the class
    public Player(int health, int mana, string name)
    {

        _health = health;
        this.mana = mana;
        this.name = name;   

        Debug.Log("Name: " + name);
        Debug.Log("Health: " + health);
        Debug.Log("Mana: " + mana);
    }

} //class
