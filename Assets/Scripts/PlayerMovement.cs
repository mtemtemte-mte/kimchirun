using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // 이동 속도를 조절하기 위한 변수입니다.
    public float moveSpeed = 5f;

    // Update 함수는 게임이 실행되는 동안 매 프레임(화면이 한 번 깜빡일 때마다) 실행됩니다.
    void Update()
    {
        // 'A' 키를 누르고 있는 동안 실행됩니다.
        if (Input.GetKey(KeyCode.A))
        {
            // 왼쪽(x좌표 마이너스)으로 이동합니다.
            // Time.deltaTime을 곱해주는 이유는 컴퓨터 성능에 상관없이 일정한 속도로 이동하게 만들기 위해서입니다.
            transform.position = transform.position + new Vector3(-1f, 0f, 0f) * moveSpeed * Time.deltaTime;
        }

        // 'D' 키를 누르고 있는 동안 실행됩니다.
        if (Input.GetKey(KeyCode.D))
        {
            // 오른쪽(x좌표 플러스)으로 이동합니다.
            transform.position = transform.position + new Vector3(1f, 0f, 0f) * moveSpeed * Time.deltaTime;
        }
    }
}