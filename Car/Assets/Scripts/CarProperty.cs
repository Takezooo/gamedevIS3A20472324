using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

[CreateAssetMenu (fileName = "car_prop", menuName = "Assets/Scripts/CarProperty")]
public class CarProperty : ScriptableObject
{
    public float gear1MovementSpeed = 20f;
    public float gear1RotationSpeed = 50.0f;

    public float gear2MovementSpeed = 25f;
    public float gear2RotationSpeed = 20.0f;

    public float gear3MovementSpeed = 30f;
    public float gear3RotationSpeed = 10.0f;
}
