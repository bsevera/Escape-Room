using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    private string _name;

    [SerializeField]
    private GameObject _BronzeKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            _BronzeKey.SetActive(true);
            _BronzeKey.transform.parent = null;
        }
    }
}
