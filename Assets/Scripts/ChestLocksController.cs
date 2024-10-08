using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChestLocksController : MonoBehaviour
{
    [SerializeField]
    private GameObject _ChestLockLeft;

    [SerializeField]
    private GameObject _ChestLockRight;

    [SerializeField]
    private GameObject _ChestCover;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if ((_ChestLockLeft.activeSelf == false) || (_ChestLockRight.activeSelf == false))
        {
            _ChestCover.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    public void LockPickInsertedInLeftLock()
    {

    }

    public void LockPickInsertedInRighttLock()
    {

    }

}
