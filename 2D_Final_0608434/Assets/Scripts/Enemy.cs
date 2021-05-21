using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Range(0, 500)]
    public float rangeTrack = 2;
    [Range(0, 50)]
    public float rangeAttack = 0.5f;
    [Range(0, 50)]
    public float speed = 2;
    [Range(0, 10)]
    public float cdAttack = 3;
    [Range(0, 1000)]
    public float attack = 20;




    private Transform player;
    private float timer;

    private void Start()
    {
        player = GameObject.Find("主角").transform;
    }



    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 0, 1, 0.3f);
        Gizmos.DrawSphere(transform.position, rangeTrack);

        Gizmos.color = new Color(0, 0, 1, 0.3f);
        Gizmos.DrawSphere(transform.position,rangeAttack);


    }


    private void Update()
    {
        Track();
    }

    private void Track()
    {
        float dis = Vector3.Distance(transform.position, player.position);

        if (dis <= rangeAttack)
        {

            Attack();

        }
        else if (dis <= rangeTrack)
        {

            transform.position = Vector3.MoveTowards(transform.position, player.position, speed*Time.deltaTime);
            
        }

    }

    private void Attack()
    {

        timer += Time.deltaTime;
        if (timer >= cdAttack)
        {
            timer = 0;
            Collider2D hit= Physics2D.OverlapCircle(transform.position, rangeAttack);
            hit.GetComponent<Player>().Hit(attack);

        }

    }


}
