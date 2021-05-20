﻿using UnityEngine;

public class Player : MonoBehaviour
{

    [Range(0,300)]
    public float speed = 10.5f;
    public bool isDead = false;
    public string cName = "主角";

    public FixedJoystick joystick;
    public Transform tra;
    public Animator ani;
    public float rangeAttack = 2.5f;
    public AudioSource aud;
    public AudioClip soundAttack;


    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.2f);
        Gizmos.DrawSphere(transform.position, rangeAttack);
  
    }

    private void Move ()
    {

        float h = joystick.Horizontal;
        tra.Translate(h * speed * Time.deltaTime, 0, 0);
        ani.SetFloat("水平",h);

    }
    public void Attack()
    {
        aud.PlayOneShot(soundAttack, 1.2f);

        RaycastHit2D hit=Physics2D.CircleCast(transform.position, rangeAttack, -transform.up,0,1<<8);

        if (hit.collider.tag == "敵人") Destroy(hit.collider.gameObject);

    }
    private void Hit()
    {

    }
    private void Dead()
    {

    }

    private void Start()
    {
        
    }

    private void Update()
    {
        Move();
    }


}
