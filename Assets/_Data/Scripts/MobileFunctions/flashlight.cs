using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{

    public GameObject Flashlight;
    bool flashlightson;

    void Start()
    {
        flashlightson = false;
    }

    public void TurnOn()
    {
        Flashlight.SetActive(true);
        flashlightson = true;
    }

    public void TurnOff()
    {
        Flashlight.SetActive(false);
        flashlightson = false;
    }

    public void ToggleFlashlight()
    {
        if (flashlightson)
            TurnOff();
        else
            TurnOn();
    }
}

