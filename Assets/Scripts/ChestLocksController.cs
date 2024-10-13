using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class ChestLocksController : MonoBehaviour
{
    [SerializeField]
    private GameObject _ChestLockLeft;

    [SerializeField]
    private GameObject _ChestLockRight;

    [SerializeField]
    private GameObject _ChestCover;

    private AudioSource _AudioSource;
    private bool _LeftLockPopped = false;
    private bool _RightLockPopped = false;

    // Update is called once per frame
    void Update()
    {
        if (_LeftLockPopped ||  _RightLockPopped)
        {
            _ChestCover.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    public void LockPickInsertedInLeftLock()
    {
        _AudioSource = _ChestLockLeft.GetComponent<AudioSource>();        
        _AudioSource.Play();

        Destroy(_ChestLockLeft, 1.0f);
        _LeftLockPopped = true;
        
    }

    public void LockPickInsertedInRighttLock()
    {
        _AudioSource = _ChestLockRight.GetComponent<AudioSource>();
        _AudioSource.Play();

        Destroy(_ChestLockRight, 1.0f);
        _RightLockPopped = true;
    }

}
