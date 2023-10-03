using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{

    public CircleProperty stats; 
    //float movementSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 pos = new Vector3(h, v, 0f).normalized;
        Vector3 movement = pos * (stats.movementSpeed * Time.deltaTime);

        transform.position += movement;

    }
}
