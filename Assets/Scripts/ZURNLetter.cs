using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZURNLetter : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _letter;

    [SerializeField] private GameObject _DrainGrate = null;
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
        Color tmpColor = _letter.color;
        _letter.alpha = 1;

        if (!_LetterFound)
        {
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
}
