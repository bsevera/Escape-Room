using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPuzzleTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _wallPuzzle;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Wall Puzzle Trigger occurred");
        _wallPuzzle.GetComponent<WallPuzzle>().PlayFirstAnimation();
    }
}
