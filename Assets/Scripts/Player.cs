using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("이동 설정")]
    public float moveSpeed = 7f;
    public float jumpPower = 10f; // 점프 힘 설정

    private Rigidbody2D rb;
    private Animator anim; // 플레이어의 애니메이션 상태를 바꾸기 위해 선언합니다
    private bool isGrounded = false; // 바닥에 점프 가능한 상태인지 확인

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>(); // 게임이 시작될 때 우리 몸에 붙어있는 Animator 컴포넌트를 가져옵니다


        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
            rb.gravityScale = 3f;
            rb.freezeRotation = true;
        }
    }

    void Update()
    {
        // 스페이스바를 눌렀을 때 점프 실행
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame && isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
        isGrounded = false;

        // 애니메이터가 연결되어 있다면, 애니메이터의 state 값을 1(점프 상태)로 바꿔줍니다
        if (anim != null)
        {
            anim.SetInteger("state", 1);
        }
    }

    // M 키로 이동
    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);
        }
        else if (context.canceled)
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }
    }

    // 혹시 Player Input의 Unity Events 방식으로 OnJump를 사용하실 경우를 위해 추가
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && isGrounded)
        {
            Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true; // 무언가에 닿으면(바닥) 다시 점프 가능해집니다

        // 바닥에 닿았을 때(착지) 애니메이터의 state 값을 2(착지 상태)로 바꿔줍니다
        if (anim != null)
        {
            anim.SetInteger("state", 2);
        }

        if (collision.gameObject.name == "ezgif.com-gif-to-sprite-converter_0")
        {
            Debug.Log("게임오버");
        }
    }
}   // ← 여기서 클래스 끝
