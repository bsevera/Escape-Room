using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.Playables;

public class WallPuzzle : MonoBehaviour
{
    [SerializeField]
    private PlayableDirector _playableDirector;

    private float _elapsedTime;
    private float _timer = 0;
    private bool _isPlaying = false;
    private bool _animation1Played = false;
    private bool _animation2Played = false;
    private bool _animation3Played = false; 

    void Update()
    {
        if (_isPlaying)
        {
            _timer += Time.deltaTime;            
            if (_timer >= _elapsedTime)
            {
                _playableDirector.Pause();
                //_playableDirector.playableGraph.GetRootPlayable(0).SetSpeed(0);
                _isPlaying = false;
            }
        }
    }

    private void SetPlaybackValues()
    {
        _elapsedTime = 1.0f;        
        _isPlaying = true;
    }

    public void PlayFirstAnimation()
    {        
        if (!_animation1Played)
        {
            SetPlaybackValues();
            _playableDirector.Play();
        }
    }

    public void PlaySecondAnimation()
    {
        SetPlaybackValues();
        _playableDirector.Play();        
    }

    public void PlayThirdAnimation()
    {
        SetPlaybackValues();
        _playableDirector.Play();        
    }
}
