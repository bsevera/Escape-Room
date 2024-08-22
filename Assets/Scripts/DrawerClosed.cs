using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerClosed : MonoBehaviour
{
    [SerializeField]
    private GameObject _drawer;

    private Vector3 _maxLoc;
    // Start is called before the first frame update
    void Start()
    {
        _maxLoc = _drawer.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localPosition.z <= _maxLoc.z) 
        { 
            this.transform.localPosition = _maxLoc; }
    }
}
