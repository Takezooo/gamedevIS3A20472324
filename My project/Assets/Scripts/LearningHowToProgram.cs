using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    // data types

    float speed = 1.4f;
    
    double mana = 15.5f;
    
    int health = 100;
    
    string playerName = "Warrior";

    bool isDead = false;

    char oneChar = 'a';

    private void Start()
    {
        
        Player Kuro = new Player(100, 200, "Kuro");

        int a = 10;
        int b = 20;
        //int c = a + b;


        //CalculateNumber(a, b);

        //StartCoroutine(ExecuteSomething());
    }

    //function with parameters without return
    void CalculateNumber(int a, int b)
    {
        int c = a + b;
        Debug.Log(c);
    }
    //function with parameters and returns a float
    float ReturnSum(float a, float b)
    {
        return a + b;
    }

    //Coroutine
    IEnumerator ExecuteSomething()
    {
        yield return new WaitForSeconds(5f);
        Debug.Log("Something is Executed");
    }


}