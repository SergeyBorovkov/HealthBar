using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HealthCounter))]
public class CureButton : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Button _cure;

    private HealthCounter _healthCounter;
    private float _curePoints = 10f;

    private void Start()
    {
        _healthCounter = GetComponent<HealthCounter>();
    }

    public void OnButtonClick()
    {
        _healthCounter.Cure(_curePoints);
    }    
}