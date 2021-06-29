using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private HealthCounter _health;
    private float _speedRatio = 5f;

    void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _health.CurrentHealth, _speedRatio * Time.deltaTime);
    }
}