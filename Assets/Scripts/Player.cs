using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("이동 설정")]
    public float moveSpeed = 7f;
    public float jumpPower = 10f; // 점프 힘 설정
    public int lives = 3;
    private Rigidbody2D rb;
    private Animator anim; // 플레이어의 애니메이션 상태를 바꾸기 위해 선언합니다
    public bool isInvincile;
    private Collider2D collider2D;
    private Animator animator;
    private Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        collider2D = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();

    }


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
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);


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
        if (context.performed)
        {
            Jump();
        }
    }




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("food"))
        {
            Debug.Log("먹었다");
            Heal();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("데미지 입었다");
            Destroy(other.gameObject);
            if (isInvincile == false)
            {
                Dmage();
            }
        }
        else if (other.gameObject.CompareTag("Gold"))
        {
            StartInvincible();
            Destroy(other.gameObject);
        }
    }


    private void Heal()
    {
        lives = Mathf.Min(lives + 1, 3);
        Debug.Log("남은채력" + lives);

        if (lives == 3)
        {

        }
    }

    private void Dmage()
    {
        lives--;
        if (lives < 0)
        {
            Debug.Log("게임오버");


        }
        Debug.Log("남은채력" + lives);

    }
    private void StartInvincible()
    {
        isInvincile = true;
        Invoke("멈춤 무적", 5f);

    }
    private void StopInvincible()
    {
        isInvincile = false;
    }
    private void KIllplayer()
    {
        collider2D.enabled = false;
        animator.enabled = false;
        rigidBody.AddForceY(5f, ForceMode2D.Impulse);

    }

}






