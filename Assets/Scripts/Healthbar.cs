using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private PlayerHealth _health;

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
        float delta = Mathf.Abs((_slider.value - _health.CurrentHealth) / _health.MaxHealth);
        var wait = new WaitForSeconds(0.01f);

        while (_slider.value != _health.CurrentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _health.CurrentHealth, delta);
            yield return wait;
        }
    }
}