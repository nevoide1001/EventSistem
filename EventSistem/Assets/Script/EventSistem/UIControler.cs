using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIcontroler : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _pointsText;
    [SerializeField] private TextMeshProUGUI _levelText;
    #endregion

    #region Callbacks
    void Start()
    {

    }

    void Update()
    {

    }
    #endregion

    #region PublicMethods
    public void UpdateSliderLife(float currentLife)
    {
        _slider.value = currentLife;
    }

    public void UpdatePoints(int currentPoints)
    {
       _pointsText.text = currentPoints.ToString();
    }

    public void UpdateLevel(int currentLevel) { 
        _levelText.text = "Level " + currentLevel.ToString();
    }
    #endregion

    #region PrivateMethods
    #endregion
}
