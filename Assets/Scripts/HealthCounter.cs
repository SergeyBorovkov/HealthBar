using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _currentHealth;

    public float CurrentHealth => _currentHealth;

    private void Start()
    {
        _currentHealth = _slider.value;
    }

    public void Cure(float healthPoints)
    {
        _currentHealth += healthPoints;

        if (_currentHealth > _slider.maxValue)
            _currentHealth = _slider.maxValue;
    }

    public void Damage(float healthPoints)
    {
        _currentHealth -= healthPoints;

        if (_currentHealth < _slider.minValue)
            _currentHealth = _slider.minValue;
    }
}