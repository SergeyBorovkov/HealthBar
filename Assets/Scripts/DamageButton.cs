using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageButton : MonoBehaviour
{    
    [SerializeField] private PlayerHealth _health;
        
    private float _damagePoints = 10f;

    public void OnButtonClick()
    {
        _health.Damage(_damagePoints);        
    }
}