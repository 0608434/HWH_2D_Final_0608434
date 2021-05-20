using UnityEngine;

public class Player : MonoBehaviour
{

    [Range(0,300)]
    public float speed = 10.5f;
    public bool isDead = false;
    public string cName = "主角";
    

}
