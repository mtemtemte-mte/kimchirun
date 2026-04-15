using UnityEngine;


public class Mover : MonoBehaviour
{
    [Header("이동 속도")]
    [SerializeField]
    private float speed = 5f;
    void Start()
    {

    }


    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}

