using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadlockController : MonoBehaviour
{

    [SerializeField]
    private GameObject PadLock1;
    [SerializeField] 
    private GameObject PadLock2;
    [SerializeField]
    private GameObject Key1;
    [SerializeField] 
    private GameObject Key2;

    private int _KeysInserted = 0;

    public void KeyInserted()
    {
        _KeysInserted++;
        
        if (_KeysInserted == 2)
        {
            DisablePadlocksAndKeys();
        }
    }

    public void KeyRemoved()
    {
        _KeysInserted--;
    }

    private void DisablePadlocksAndKeys()
    {
        PadLock1.SetActive(false);
        PadLock2.SetActive(false);

        Key1.SetActive(false);
        Key2.SetActive(false);
    }
}
