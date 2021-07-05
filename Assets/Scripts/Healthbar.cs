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

    public void ChangeBar ()
    {       
        {
            StartCoroutine(SmoothMove());            
        }
    }

    private IEnumerator SmoothMove()
    {
        int steps = 20;
        float delta = Mathf.Abs((_slider.value - _health.CurrentHealth) / steps);
        var wait = new WaitForSeconds(0.1f);

        for (int i = 0; i < steps; i++)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _health.CurrentHealth, delta);
            yield return wait;         
        }        
    }
}