using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.XR.Interaction.Toolkit;

public class Flashlight : MonoBehaviour
{
    [SerializeField]
    private GameObject _pointLight;

    private bool _isBeingHeld = false;
    private bool _lightIsOn = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Grabbed()
    {
        _isBeingHeld = true;
        
    }

    public void Dropped()
    {
        _isBeingHeld = false;
    }

    public void Activated()
    {
        if (_isBeingHeld)
        {
                _pointLight.SetActive(true);
            _lightIsOn = true;
        }

    }
}
