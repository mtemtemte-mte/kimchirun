using UnityEngine;

public class InfiniteBackground : MonoBehaviour
{
    [Header("이동 속도")]
    public float scrollSpeed = 5f;        // 숫자 클수록 빠름

    [Header("배경 반복 너비 (이미지 가로 길이)")]
    public float backgroundWidth = 20f;   // ← 여기서 본인 이미지 가로 길이 입력!

    private Transform[] backgrounds;      // 2개의 배경 Transform

    void Start()
    {
        // 자식으로 있는 배경 2개를 찾아서 배열에 넣음
        backgrounds = new Transform[2];
        backgrounds[0] = transform.GetChild(0);
        backgrounds[1] = transform.GetChild(1);
    }

    void Update()
    {
        // 배경 전체를 왼쪽으로 이동 (오른쪽으로 스크롤하려면 - 대신 + 사용)
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        // 각 배경이 화면 왼쪽으로 완전히 벗어나면 오른쪽 끝으로 순간 이동
        for (int i = 0; i < backgrounds.Length; i++)
        {
            if (backgrounds[i].position.x < -backgroundWidth)
            {
                // 오른쪽 끝으로 이동 (2배 너비만큼)
                backgrounds[i].position += Vector3.right * (backgroundWidth * 2);
            }
        }
    }
}