using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int rotationSpeed = 200;
        int movementSpeed = 1;
        Vector3 position = new Vector3(movementSpeed * Time.deltaTime, 0f, 0f);
        transform.localPosition += position;
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
