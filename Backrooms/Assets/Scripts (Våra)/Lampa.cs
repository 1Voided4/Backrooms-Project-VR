using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;


public class PannLampaSkript : MonoBehaviour
{
    public short LightStrenght;

    private void Update()
    {
        
    }
    public void FlashLightOnOff()
    {
        Input

        if (XRInput.GetDown(OVRInput))
        {

        }
        this.GetComponent<Light>().intensity = LightStrenght;
    }

}