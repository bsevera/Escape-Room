using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZURNLetter : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _letter;

    public void IlluminateLetter()
    {
        _letter.alpha = 42;
    }
}
