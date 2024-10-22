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

    public void Update()
    {
        if (_KeysInserted == 2)
        {
            DisablePadlocksAndKeys();
        }
    }

    public void KeyInsertedTopLock()
    {
        _KeysInserted++;
        PadLock1.GetComponent<AudioSource>().Play();
    }

    public void KeyInsertedBottomLock()
    {
        _KeysInserted++;
        PadLock2.GetComponent<AudioSource>().Play();
    }

    //public void KeyInserted()
    //{
    //    _KeysInserted++;

    //    if (_KeysInserted == 2)
    //    {
    //        DisablePadlocksAndKeys();
    //    }
    //}

    public void KeyRemoved()
    {
        _KeysInserted--;
    }

    private void DisablePadlocksAndKeys()
    {
        Destroy(PadLock1, 1.2f);
        Destroy(PadLock2, 1.2f);

        //PadLock1.SetActive(false);
        //PadLock2.SetActive(false);

        Destroy(Key1, 1.2f);
        Destroy(Key2, 1.2f);
        //Key1.SetActive(false);
        //Key2.SetActive(false);
    }
}
