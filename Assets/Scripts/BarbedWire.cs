using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbedWire : MonoBehaviour
{
    private AudioSource _audioSource = null;
    public void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ClipWire()
    {
        _audioSource.Play();
        Destroy(this.gameObject, 0.3f);
    }

    
    
}
