using UnityEngine;

    


public class PlayerController : MonoBehaviour
{
    // 변수 선언
    private int hp = 100;
    private int score = 0;

    // 데미지를 받는 함수
    void TakeDamage(int damage)
    {
        hp = hp - damage;

        Debug.Log("데미지: " + damage + " / 남은 체력: " + hp);
    }

    // 현재 HP를 반환하는 함수
    int GetMaxHP()
    {
        return hp;
    }

    // 시작 함수
    void Start()
    {
        TakeDamage(25);
        TakeDamage(40);

        int max = GetMaxHP();                    // HP 가져오기
        Debug.Log("최대 체력: " + max);
    }
}