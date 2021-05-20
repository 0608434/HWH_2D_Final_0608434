using UnityEngine;

public class Player : MonoBehaviour
{

    [Range(0,300)]
    public float speed = 10.5f;
    public bool isDead = false;
    public string cName = "主角";

    public FixedJoystick joystick;
    public Transform tra;
    public Animator ani;

    private void Move ()
    {

        float h = joystick.Horizontal;
        tra.Translate(h * speed * Time.deltaTime, 0, 0);
        ani.SetFloat("水平",h);

    }
    private void Attack()
    {

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
