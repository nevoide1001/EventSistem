using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSistem : MonoBehaviour
{
    #region Events
    public event Action OnKeyDamage;
    public event Action OnKeyHeal;
    public event Action OnKeyAddPoints;
    public event Action OnKeyLevelUp;
    #endregion

    #region Callbacks
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            OnKeyDamage?.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            OnKeyHeal?.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            OnKeyAddPoints?.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            OnKeyLevelUp?.Invoke();
        }
    }
    #endregion
}
