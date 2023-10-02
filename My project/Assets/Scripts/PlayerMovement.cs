using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        Vector2 pos = transform.position;
        //pos.x += h * speed * Time.deltaTime;
        pos.x += h * speed * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && pos.y <= -2.51f)
        {
            pos.y += Mathf.Sqrt(1 * -3.0f * -9.81f);
        }

        transform.position = pos;
    }

    //Collision detector
    /*
    private void OnCollisionEnter2D(Collision2D col)
    {

        Debug.Log("Collided");

    }
    */


}

