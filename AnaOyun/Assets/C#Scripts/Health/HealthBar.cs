using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HealthBar : MonoBehaviour
{

    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalHealtBar;
    [SerializeField] private Image currentHealtBar;
     
    private void Start()
    {
        currentHealtBar.fillAmount = playerHealth.currentHealth / 10;

    }
    private void Update()
    {
        currentHealtBar.fillAmount = playerHealth.currentHealth / 10;
        
    }

}