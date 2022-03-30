using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator animasyon;
    private bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
        animasyon = GetComponent<Animator>();
    }
    public void TakeDamage(float _damage)
    {

        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            animasyon.SetTrigger("hurt");
        }
        else//ölüm
        {
            if (!dead)
            {
                animasyon.SetTrigger("die");
                GetComponent<PlayerMove>().enabled = false;
                dead = true;
            }

        }
        //currentHealth -= _damage;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
        }
    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);

    }

}
