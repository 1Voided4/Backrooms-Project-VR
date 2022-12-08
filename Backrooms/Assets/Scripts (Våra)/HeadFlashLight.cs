using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HeadFlashLight : MonoBehaviour
{
    private GameObject camera;
    private Vector3 cameraP;
    private Quaternion cameraR;

    private GameObject FLight;
    private Vector3 FLightP;
    private Quaternion FLightR;

    public InputDevice _RC;
    public InputDevice _LC;

    void Awake()
    {
        camera = GameObject.Find("Main Camera");
        getRotAndPos();
        FLight = GameObject.Find("Spot Light");

        print(FLightP);
        print(cameraR);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LightOnOff()
    {
        if (Input.Get(Button.PrimaryThumbStick)) print("Welcome to yomama town");

       
    }


    void GetRotAndPos()
    {
        cameraP = camera.transform.position;
        cameraR = camera.transform.localRotation;

        FLightP = FLight.transform.position;
        FlightR = FLight.transform.localRotation;

    }
}
