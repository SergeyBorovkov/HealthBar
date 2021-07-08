using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class PlayerHealth : MonoBehaviour
{    
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _minHealth = 0;
    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private UnityEvent _changed;


    public float CurrentHealth => _currentHealth;
    public float MinHealth => _minHealth;
    public float MaxHealth => _maxHealth;

    public void Cure(float healthPoints)
    {
        _currentHealth += healthPoints;

        if (_currentHealth > _maxHealth)
            _currentHealth = _maxHealth;

        _changed.Invoke();
    }

    public void Damage(float healthPoints)
    {
        _currentHealth -= healthPoints;

        if (_currentHealth < _minHealth)
            _currentHealth = _minHealth;

        _changed.Invoke();
    }
}