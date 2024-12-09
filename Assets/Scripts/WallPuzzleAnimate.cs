using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPuzzleAnimate : MonoBehaviour
{

    GameObject _wallPuzzle = null;
    float _wheelValue = 0;
    bool _firstAnimationPlayed = false;
    bool _secondAnimationPlayed = false;
    bool _thirdAnimationPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        _wallPuzzle = GameObject.Find("Wall Puzzle");
    }

    // Update is called once per frame
    void Update()
    {
        if (_wheelValue <= -0.5 && !_firstAnimationPlayed)
        {
            _wallPuzzle.GetComponent<WallPuzzle>().PlayFirstAnimation();
            _firstAnimationPlayed = true;
        }

        if (_wheelValue <= -1.0 && _firstAnimationPlayed && !_secondAnimationPlayed)
        {
            _wallPuzzle.GetComponent<WallPuzzle>().PlaySecondAnimation();
            _secondAnimationPlayed = true;
        }

        //if (_wheelValue <= -1.5 && _firstAnimationPlayed && _secondAnimationPlayed && !_thirdAnimationPlayed)
        //{
        //    _wallPuzzle.GetComponent<WallPuzzle>().PlayThirdAnimation();
        //    _thirdAnimationPlayed = true;
        //}

    }

    public void AnimateWall(int animationSequence)
    {
        if (_wallPuzzle != null)
        {
            switch (animationSequence)
            {
                case 1:
                    _wallPuzzle.GetComponent<WallPuzzle>().PlayFirstAnimation();
                    break;
                case 2:
                    _wallPuzzle.GetComponent<WallPuzzle>().PlaySecondAnimation();
                    break;
                case 3:
                    _wallPuzzle.GetComponent<WallPuzzle>().PlaySecondAnimation();
                    break;

            }
            
        }
    }

    public void AnimateWallWheel(float value)
    {
        Debug.Log("value = " + value.ToString());

        if (_wallPuzzle != null)
        {
            if (value <= -0.1)
                _wheelValue = value;
            //_wallPuzzle.GetComponent<WallPuzzle>().PlayFirstAnimation();
        } 
    }

}
