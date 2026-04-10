using UnityEngine;

public class AutoRotate2D : MonoBehaviour
{
    [Header("회전 속도")]
    public float speed = 180f;     // 180이면 1초에 반 바퀴, 360이면 1초에 한 바퀴

    [Header("회전 방향")]
    public bool clockwise = true;  // true = 시계 방향, false = 반시계 방향

    void Update()
    {
        float direction = clockwise ? -1f : 1f;   // 시계/반시계 방향 결정

        // 2D에서는 Z축으로 회전
        transform.Rotate(0f, 0f, speed * direction * Time.deltaTime);
    }
}