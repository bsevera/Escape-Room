using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseChest : MonoBehaviour
{
    [SerializeField]
    private GameObject _ChestCover;

    // Start is called before the first frame update
    void Start()
    {
        _ChestCover.transform.Rotate(90, 0, 0, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
