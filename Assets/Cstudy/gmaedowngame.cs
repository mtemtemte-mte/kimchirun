using System.IO.Compression;
using UnityEngine;
using UnityEngine.InputSystem;

public class gmaedowngame : MonoBehaviour
{
    private int hp = 100;
    private bool isJumping;
    void Start()
    {

    }

    void Update()
    {
        var key = Keyboard.current;
        if (key == null) return;

        if (key.spaceKey.isPressed) 
        {
            Debug.Log("스페이스는 점푸야");
            isJumping = true;
            if (isJumping)
            {
                Debug.Log("공중");
            }
            else
            {
                isJumping = true;
                Debug.Log("공중 아님");
            }

        }
        if (key.zKey.isPressed) 
        {
            Debug.Log("[Z]키는 공격");

        }
        if (key.xKey.isPressed) 
        {
            Debug.Log("[X]키는 방어");
        }
         if (key.cKey.isPressed)
        {
            Debug.Log("[C]키는 상태창");
            if(hp >= 70)
            {
                Debug.Log("컨디션 좋음");
            }
            else if(hp <= 30)
            {
                Debug.Log("컨디션 안 좋음");
            }
            else 
            {
                Debug.Log("당신은 당신의 처참한 실력으로 인해 죽었습니다");
            }

        }
    }
}

