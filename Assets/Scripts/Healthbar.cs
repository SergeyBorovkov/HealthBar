using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Healthbar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private PlayerHealth _health;
    [SerializeField] private float _speed = 10f;
        

    private void Awake()
    {
        _slider.value = _health.CurrentHealth;
        _slider.minValue = _health.MinHealth;
        _slider.maxValue = _health.MaxHealth;
    }

    public void Change()
    {        
        StartCoroutine(SmoothMove());        
    }

    private IEnumerator SmoothMove()
    {       
        float delta = _speed * Time.deltaTime;        

        while (_slider.value != _health.CurrentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _health.CurrentHealth, delta);
            yield return null;
        }
    }
}