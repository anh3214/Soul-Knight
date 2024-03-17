using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private Health _health;

    [SerializeField]
    private RectTransform _rectTransform;

    [SerializeField]
    private RectMask2D rectMask2D;

    [SerializeField]
    private TMP_Text _hp;

    [SerializeField]
    private TMP_Text _shield; 
    
    [SerializeField]
    private bool _IsShield = false;

    private float _maxRightMask;
    private float _initialRightMask;
   

    private void Start()
    {
        if (_IsShield)
        {
            _maxRightMask = _rectTransform.rect.width - rectMask2D.padding.x - rectMask2D.padding.z;
            _shield.SetText($"{_health.currentShiled}/{_health.maxShiled}");
            _initialRightMask = rectMask2D.padding.z;
        }
        else
        {
            _maxRightMask = _rectTransform.rect.width - rectMask2D.padding.x - rectMask2D.padding.z;
            _hp.SetText($"{_health.currentHealth}/{_health.maxHealth}");
            _initialRightMask = rectMask2D.padding.z;
        }

    }

    public void Update()
    {
        if( _IsShield )
        {
            var targetWidth = _health.currentShiled * _maxRightMask / _health.maxShiled;
            var newRightMask = _maxRightMask + _initialRightMask - targetWidth;
            var padding = rectMask2D.padding;
            padding.z = newRightMask;
            rectMask2D.padding = padding;
            _shield.SetText($"{_health.currentShiled}/{_health.maxShiled}");
        }
        else
        {
            var targetWidth = _health.currentHealth * _maxRightMask / _health.maxHealth;
            var newRightMask = _maxRightMask + _initialRightMask - targetWidth;
            var padding = rectMask2D.padding;
            padding.z = newRightMask;
            rectMask2D.padding = padding;
            _hp.SetText($"{_health.currentHealth}/{_health.maxHealth}");
        }
    }
}
