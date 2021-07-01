using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Slider _slider;    
    [SerializeField] private PlayerHealth _health;
        
    private float _curePoints = 10f;

    public void OnButtonClick()
    {
        _health.Damage(_curePoints);
    }
}