using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrainGrateLock : MonoBehaviour
{
    private string key = "ZURN";

    [SerializeField]
    private GameObject[] _LetterCanvases = new GameObject[4];
    [SerializeField]
    private AudioSource _AudioSource;

    private int _KeyCountDown = 0;

    public void Start()
    {
        for (int i = 0; i < _LetterCanvases.Length; i++)
        {
            _KeyCountDown += (i + 1);
        }
        Debug.Log("KeyCountdown (Start) = " + _KeyCountDown);
    }

    public void EnableLetter(string letter)
    {
        int index = key.IndexOf(letter);
        if (index > -1)
        {
            Debug.Log("Enabling the letter '" + letter + "' at index " + index.ToString());
            _LetterCanvases[index].SetActive(true);
            CheckKeyCountdown(index + 1);
        }
    }

    private void CheckKeyCountdown(int value)
    {
        _KeyCountDown -= value;

        Debug.Log("KeyCountdown = " + _KeyCountDown);

        if (_KeyCountDown == 0)
        {
            //Play grate opening audio and animate grate opening
            _AudioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
