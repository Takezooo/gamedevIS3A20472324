using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.VersionControl;

public class TestingButton : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI TextToChange;
    [SerializeField]
    private string Message = "Testing";
    private int Increment = 1;

    public void ButtonPressed()
    {
        //Debug.Log("Button is pressed");
        TextToChange.text = Message + (Increment++);
    }
}
