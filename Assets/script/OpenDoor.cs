using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{
    public GameObject TextDisplay;
    public float TheDistance = PlayerCast.DistanceFromTarget;

    void Update()
    {
        TheDistance = PlayerCast.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 4)
        {
            TextDisplay.GetComponent<Text>().text = "Press Button";
        }

    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }
}
