using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSistem : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields
    [SerializeField] private Points _points;
    [SerializeField] private Healt _playerHealth;
    [SerializeField] private UIcontroler _ui;
    [SerializeField] private SoundControler _sound;
    [SerializeField] private InputSistem _inputSistem;
    #endregion

    #region Callbacks
    void Start()
    {
        _playerHealth.OnGetDamage += OnGetDamage;
        _playerHealth.OnGetHeal += OnGetHeal;
        _playerHealth.OnGetDie += OnGetDie;
        _points.OnGetPoints += OnAddPoint;
        _points.OnLevelUp += OnaddLevel;
        _inputSistem.OnKeyDamage += OnInputDamage;
        _inputSistem.OnKeyHeal += OnInputHeal;
        _inputSistem.OnKeyAddPoints += () => _points.AddPoints(10);
        _inputSistem.OnKeyLevelUp += () => _points.AddLevels(1);

    }

    void Update()
    {

    }
    #endregion

    #region PublicMethods
    #endregion

    #region PrivateMethods

    private void OnGetDamage()
    {
        _sound.PlayDamageSound();
        _ui.UpdateSliderLife(_playerHealth.CurrentHealth);
    }

    private void OnGetHeal()
    {
        _ui.UpdateSliderLife(_playerHealth.CurrentHealth);
    }

    private void OnGetDie()
    {
        _sound.PlayDieSound();
        Destroy(_playerHealth.gameObject);
    }

    private void OnAddPoint()
    {
        _ui.UpdatePoints(_points.CurrentPoints);
    }

    private void OnaddLevel()
    {
        _ui.UpdateLevel(_points.CurrentLevel);
    }

    private void OnInputDamage()
    {
        _playerHealth.GetDamage(10f);
    }

    private void OnInputHeal()
    {
        _playerHealth.Heal(5f);
    }
    #endregion


}
