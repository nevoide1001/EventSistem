using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControler : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields

    private AudioSource _audioSource;
    [SerializeField] private AudioClip damageSound;
    //[SerializeField] private AudioClip healSound;
    [SerializeField] private AudioClip dieSound;

    #endregion

    #region Callbacks
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    #endregion

    #region PublicMethods
    public void PlayDamageSound()
    {
        _audioSource.clip = damageSound;
        _audioSource.Play();
    }

    /*public void PlayHealSound()
    {
        _audioSource.clip = healSound;
        _audioSource.Play();
    }*/

    public void PlayDieSound()
    {
        _audioSource.clip = dieSound;
        _audioSource.Play();
    }
    #endregion

    #region PrivateMethods
    #endregion
}
