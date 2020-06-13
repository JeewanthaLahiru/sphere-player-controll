using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{
    public GameObject TextDisplay;
    public float TheDistance = PlayerCast.DistanceFromTarget;

    public GameObject TheDoor;

    void Update()
    {
        TheDistance = PlayerCast.DistanceFromTarget;
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 4)
            {
                StartCoroutine(OpenTheDoor());
            }
        }
    }

    void OnMouseOver()
    {
        if (TheDistance <= 4)
        {
            TextDisplay.GetComponent<Text>().text = "E ඔබන්න ";
        }

    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator OpenTheDoor()
    {
        TheDoor.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1);
        TheDoor.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(5);
        TheDoor.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1);
        TheDoor.GetComponent<Animator>().enabled = false;
    }
}
