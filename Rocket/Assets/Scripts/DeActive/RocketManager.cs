using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketManager : MonoBehaviour

{
    #region RocketPositionPoints
    public Transform TopLeftF;
    public Transform TopLeftB;
    public Transform TopRightF;
    public Transform TopRightB;
    public Transform BotLeftF;
    public Transform BotLeftB;
    public Transform BotRightF;
    public Transform BotRightB;
    public Transform TopCenter;
    public Transform BotCenter;

    #endregion

    private float _height;

    public float Height
    {
        get { return _height; }
        set
        {
            if (!(_height < 0))
                _height = value;
            else
                _height = 0;
        }
    }

    void Awake()
    {
        Height = BotCenter.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
