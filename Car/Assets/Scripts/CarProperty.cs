using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

[CreateAssetMenu (fileName = "car_prop", menuName = "Assets/Scripts/CarProperty")]
public class CarProperty : ScriptableObject
{
    public float gear1MovementSpeed = 10f;
    public float gear1RotationSpeed = 500f;

    public float gear2MovementSpeed = 20f;
    public float gear2RotationSpeed = 200f;

    public float gear3MovementSpeed = 30f;
    public float gear3RotationSpeed = 100f;

    public float left = 90f;
    public float right = -90f;
}
