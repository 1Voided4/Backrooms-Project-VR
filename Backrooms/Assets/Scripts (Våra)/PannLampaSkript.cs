using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannLampaSkript : MonoBehaviour
{
    public GameObject aaa;
    [SerializeField] public Material mat;
    private void Awake()
    {
        print("aaa");
        aaa = GameObject.Find("AAA");
        print(aaa);

        var aaaRenderer = aaa.GetComponent<Renderer>();

        mat.color = Color.blue;

    }
    void Update()
    {


        OVRInput.Update();

        if (OVRInput.Get(OVRInput.Button.One))
        {
            FlashLightOn();
            Debug.Log("Hej");
            mat.color = Color.red;
        }
    }

    public short LightStrenght;

    public void FlashLightOn()
    {
        print("aaa");

    }
    public void FlashLightOff()
    {

    }
}