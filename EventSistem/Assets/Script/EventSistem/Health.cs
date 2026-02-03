using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healt : MonoBehaviour
{
    #region Properties
    public float CurrentHealth 
    { 
        get 
        {
            return _currentHealth;
        }
        set 
        { 
            _currentHealth = value;

            if (value <= 0)
            {
                _currentHealth = 0;
                Die();
            }

            if (value > _maxHealth)
            {
                _currentHealth = _maxHealth;
            }
        } 
    }
    
    public event Action OnGetDamage;
    public event Action OnGetHeal;
    public event Action OnGetDie;

    #endregion

    #region Fields
    [SerializeField] private float _maxHealth = 100f;
    [SerializeField] private float _currentHealth;
    [SerializeField] private bool _die = false;
    #endregion

    #region Callbacks
    void Start()
    {
        CurrentHealth = _maxHealth;
    }
    #endregion

    #region Public Methods
    public void GetDamage(float damage)
    {
        if (!_die)
        {
            CurrentHealth -= damage;
            OnGetDamage?.Invoke();
        }
    }

    public void Heal(float healAmount)
    {
        if (!_die)
        {
            CurrentHealth += healAmount;
            OnGetHeal?.Invoke();
        }
    }
    #endregion

    #region Private Methods
    private void Die()
    {
        if (!_die)
        {
            _die = true;
            OnGetDie?.Invoke();
        }
    }
    #endregion
}
