using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HealthCounter))]
public class HealthbarChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    private HealthCounter _healthCounter;
    private float _speedRatio = 5f;

    private void Start()
    {
        _healthCounter = GetComponent<HealthCounter>();        
    }

    void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _healthCounter.CurrentHealth, _speedRatio * Time.deltaTime);
    }
}