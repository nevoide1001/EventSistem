using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    #region Properties
    public int CurrentPoints { get; set; }
    public event Action OnGetPoints;
    public int CurrentLevel { get; set; }
    public event Action OnLevelUp;
    #endregion

    #region Fields
    #endregion

    #region Callbacks
    void Start()
    {
        CurrentPoints = 0;
        CurrentLevel = 1;
    }

    /*void Update()
    {

    }*/
    #endregion

    #region PublicMethods

    public void AddPoints(int points)
    {
        CurrentPoints += points;
        OnGetPoints?.Invoke();
    }
    public void AddLevels(int levels)
    {
        CurrentLevel += levels;
        OnLevelUp?.Invoke();
    }
    #endregion

    #region PrivateMethods
    #endregion
}
