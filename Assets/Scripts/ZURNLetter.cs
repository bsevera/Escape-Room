using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZURNLetter : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _letter;

    [SerializeField] 
    private GameObject _DrainGrate = null;

    [SerializeField]
    private DrainGrateLock _DrainGrateLock;

    private AudioSource _AudioSource;
    private bool _LetterFound = false;

    public void Start()
    {
        _DrainGrateLock = _DrainGrate.GetComponent<DrainGrateLock>();
        _AudioSource = _DrainGrate.GetComponent<AudioSource>();
    }

    public void IlluminateLetter()
    {
        Debug.Log("Illuminate Letter" + _letter.text.ToString());
        Color tmpColor = _letter.color;
        _letter.alpha = 42;

        if (!_LetterFound)
        {
            Debug.Log("Letter '" + _letter.text.ToString() + "' was found");
            _LetterFound = true;
            _DrainGrateLock.EnableLetter(_letter.text);
            _AudioSource.time = 1;
            _AudioSource.Play();
        }
    }
    public void HideLetter()
    {
        _letter.alpha = 0;
    }

    //public void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("OnTriggerEnter");

    //    if (other.tag == "Flashlight")
    //    {
    //        Debug.Log("Setting letter visibility");
    //        _letter.alpha = 42;
    //    }
    //}

    //public void OnTriggerExit(Collider other)
    //{
    //    _letter.alpha = 0;
    //}

}
