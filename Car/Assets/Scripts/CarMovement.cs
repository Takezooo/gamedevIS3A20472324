using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public CarProperty Gear;
    public float carSpeed = 10f;
    public float carRotation = 10f;

    // Update is called once per frame
    void Update()
    {
        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //carSpeed = Gear.gear1MovementSpeed;
        //carRotation = Gear.gear1RotationSpeed;

        Vector3 pos = new Vector3(h, v, 0f).normalized;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            carSpeed = Gear.gear1MovementSpeed;
            carRotation = Gear.gear1RotationSpeed;
            Debug.Log("Shifted to Gear 1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            carSpeed = Gear.gear2MovementSpeed;
            carRotation = Gear.gear2RotationSpeed;
            Debug.Log("Shifted to Gear 2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            carSpeed = Gear.gear3MovementSpeed;
            carRotation = Gear.gear3RotationSpeed;
            Debug.Log("Shifted to Gear 3");
        }


        Vector3 movement = pos * (carSpeed * Time.deltaTime);
        transform.position += movement;


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * carRotation * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back * carRotation * Time.deltaTime);

        }

    }
}
