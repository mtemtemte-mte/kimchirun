using UnityEngine;
using UnityEngine.InputSystem;

public class Test2 : MonoBehaviour
{
    int hp = 100;
    int damage;

    void TakeDmage(int damgeAmount)
    {
        hp = hp - damgeAmount;
        Debug.Log($"데미지를 받음 {damgeAmount} 남은 채력 {hp}");
    }
    int Maxhp()
    {
        return hp;
    }

    void Start()
    {
        int max = Maxhp();
        TakeDmage(17);
        Debug.Log("start");
    }

    void Update()
    {   
        var kaybord = Keyboard.current;
        if(kaybord == null) return;
        
        if(kaybord.spaceKey.isPressed)
        {
            Debug.Log("영도 슈퍼 알포스");
        }


    }

}



