using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class InputData : MonoBehaviour
{
    public InputDevice rightcontroller;

    void Update()
    {
        if (!rightcontroller.isValid)
        {
            InitializeInputDevice(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Right, ref rightcontroller);
        }
    }

    private void InitializeInputDevice(InputDeviceCharacteristics characteristics, ref InputDevice inputDevice)
    {
        List<InputDevice> devices = new List<InputDevice>();

        InputDevices.GetDevicesWithCharacteristics(characteristics, devices);

        if(devices.Count > 0){
            inputDevice = devices[0];
        }

    }
}
