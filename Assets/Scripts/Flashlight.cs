using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Flashlight : MonoBehaviour
{
    [SerializeField]
    private GameObject _pointLight;

    private bool _isBeingHeld = false;
    private bool _lightIsOn = false;

    //private InputDevice _device;
    // Start is called before the first frame update
    //void Start()
    //{
    //}

    // Update is called once per frame
    void Update()
    {
        if (_isBeingHeld)
        {           
            if (Input.GetButtonUp("Fire1"))
            //if (Input.GetButton("Fire1"))
            {
                if (!_lightIsOn)
                {
                    _pointLight.SetActive(true);
                    _lightIsOn = true;
                    Debug.Log("Light is on");
                }
                else
                {
                    _pointLight.SetActive(false);
                    _lightIsOn = false;
                    Debug.Log("Light is off");
                }
            }
        }
    }

    //private InputDevice GetDevice()
    //{
    //    var rightHandDevices = new List<UnityEngine.XR.InputDevice>();
    //    UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.RightHand, rightHandDevices);

    //    if (rightHandDevices.Count == 0)
    //    {
    //        Debug.Log("No righthand devices found");
    //    }
    //    else if (rightHandDevices.Count == 1)
    //    {
    //        var device = rightHandDevices[0];
    //        Debug.Log("Righthand device found");
    //    }
    //    else if (rightHandDevices.Count > 1)
    //    {
    //        Debug.Log(rightHandDevices.Count.ToString() + " right hand devices were found");
    //    }

    //    return rightHandDevices[0];
    //}

    public void Grabbed()
    {
        _isBeingHeld = true;
        
    }

    public void Dropped()
    {
        _isBeingHeld = false;
    }

}
