using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CureButton : MonoBehaviour
{    
    [SerializeField] private PlayerHealth _health;
        
    private float _curePoints = 10f;
    
    public void OnButtonClick()
    {
        _health.Cure(_curePoints);
    }    
}