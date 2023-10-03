using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

[CreateAssetMenu (fileName = "circle_prop", menuName = "Assets/Scripts/CircleProperty")]
public class CircleProperty : ScriptableObject
{
    public float movementSpeed = 10f;
}
