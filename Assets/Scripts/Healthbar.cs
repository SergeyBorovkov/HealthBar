using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private PlayerHealth _health;

    private float _speedRatio = 5f;

    private void Awake()
    {
        _slider.value = _health.CurrentHealth;
        _slider.minValue = _health.MinHealth;
        _slider.maxValue = _health.MaxHealth;
    }

    private void Update()
    {
        if (_slider.value != _health.CurrentHealth)        
            _slider.value = Mathf.MoveTowards(_slider.value, _health.CurrentHealth, _speedRatio * Time.deltaTime);
    }
}