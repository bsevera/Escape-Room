using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    private string _name;

    [SerializeField]
    private GameObject _BronzeKey;

    private AudioSource _audioSource = null;
    private bool _audioPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();               
    }


    public void DoGazeRegistration()
    {
        Debug.Log("Gaze Connected to " + _name);
    }

    private void OnCollisionEnter(Collision collision)
    {
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "BTTF")
        {
            if (!_audioPlayed)
            {
                _audioSource.Play();
                _audioPlayed = true;
            }

            _BronzeKey.SetActive(true);
            _BronzeKey.transform.parent = null;
        }
    }
}
