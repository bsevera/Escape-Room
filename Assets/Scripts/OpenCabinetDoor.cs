using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCabinetDoor : MonoBehaviour
{
    [SerializeField]
    private GameObject _CabinetDoor;

    [SerializeField]
    private AudioClip _CabinetDoorSound;

    private AudioSource _audioSource;

    public void Start()
    {
        SetAudioSourceAndClip();
    }

    private void SetAudioSourceAndClip()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void OpenDoor()
    {
        _audioSource.Play();
        _CabinetDoor.GetComponent<Rigidbody>().isKinematic = false;
    }
}
