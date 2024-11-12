using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Flashlight : MonoBehaviour
{
    [SerializeField]
    private GameObject _pointLight;

    [SerializeField]
    Transform _rayOrigin;

    private bool _isBeingHeld = false;
    private bool _lightIsOn = false;
    private int _batteryCount = 0;

    private GameObject _lastIlluminated = null;

    XRSocketInteractor _si;

    private void Start()
    {
        _si = GetComponent<XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_isBeingHeld)
        {           
            if (Input.GetButtonUp("Fire1") && _batteryCount == 2)
            {
                if (!_lightIsOn)
                {
                    _pointLight.SetActive(true);
                    _lightIsOn = true;                    
                }
                else
                {                    
                    _pointLight.SetActive(false);
                    _lightIsOn = false;

                    if (_lastIlluminated != null)
                        HideLetter(_lastIlluminated);
                }
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {        

        if (_lightIsOn)
        {
            if (other.tag == "Letter")
            {
                List<GameObject> childObjects = new List<GameObject>();
                other.gameObject.GetChildGameObjects(childObjects);
                childObjects[0].GetComponent<ZURNLetter>().IlluminateLetter();

                _lastIlluminated = childObjects[0];
            }
        }            
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Letter")
        {
            List<GameObject> childObjects = new List<GameObject>();
            other.gameObject.GetChildGameObjects(childObjects);
            HideLetter(childObjects[0]);
        }
    }

    private void HideLetter(GameObject letter)
    {
        letter.GetComponent<ZURNLetter>().HideLetter();
    }

    public void Grabbed()
    {
        _isBeingHeld = true;
        
    }

    public void Dropped()
    {
        _isBeingHeld = false;
    }

    public void AddBattery()
    {
        IXRSelectInteractable objName = _si.GetOldestInteractableSelected();

        _batteryCount++;
        Debug.Log(objName.transform.name + " in socket of " + transform.name);
        GameObject objToDestroy = GameObject.Find(objName.transform.name);
        AudioSource audioSource = objToDestroy.GetComponent<AudioSource>();

        if (objToDestroy != null)
        {
            audioSource.Play();
            Destroy(objToDestroy, 0.5f);
            
        }
    }
}
