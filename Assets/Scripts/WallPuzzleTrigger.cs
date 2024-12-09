using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPuzzleTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _wallPuzzle;
    [SerializeField]
    private int _puzzleAnimation;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Wall Puzzle Trigger occurred");
        switch (_puzzleAnimation)
        {
            case 1:
                _wallPuzzle.GetComponent<WallPuzzle>().PlayFirstAnimation();
                break;
            case 2:
                _wallPuzzle.GetComponent<WallPuzzle>().PlaySecondAnimation();
                break;
            case 3:
                _wallPuzzle.GetComponent<WallPuzzle>().PlayThirdAnimation();
                break;
            default:
                break;
        }            
        
    }

    public void AnimateWall()
    {
       
            GameObject gobj = GameObject.Find("Wall Puzzle");
            if (gobj != null)
            {
                gobj.GetComponent<WallPuzzle>().PlayFirstAnimation();
            }
            //_wallPuzzle.GetComponent<WallPuzzle>().PlayFirstAnimation();
    }
}
