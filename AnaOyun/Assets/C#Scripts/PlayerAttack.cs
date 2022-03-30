using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]private float attackCooldown;
    private Animator animasyon;
    private PlayerMove playerMove;
    private float coolddownTimer = Mathf.Infinity;


    private void Awake()
    {
        animasyon = GetComponent<Animator>();
        playerMove = GetComponent<PlayerMove>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0) && coolddownTimer > attackCooldown && playerMove.canAttack())
        {
            Attack();
        }
        coolddownTimer += Time.deltaTime;

    }
    private void Attack()
    {
        animasyon.SetTrigger("attack");
        coolddownTimer = 0; 
    }

}
