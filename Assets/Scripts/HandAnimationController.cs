using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class HandAnimationController : MonoBehaviour
{

    public InputDeviceCharacteristics controllerType;
    public InputDevice thisController;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> controllerDevices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerType, controllerDevices);

        thisController = controllerDevices[0];
        Debug.Log(thisController.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
