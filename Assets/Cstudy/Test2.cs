using UnityEngine;

    
public class Test2 : MonoBehaviour
{
    int hp= 100;
    int damage;

    void TakeDmage(int damgeAmount)
    {
         hp = hp- damgeAmount;
        Debug.Log ($"데미지를 받음 {damgeAmount} 남은 채력 {hp}");
    }


    void Start()
    {
        TakeDmage(17);
        Debug.Log ("start");
    }
    
}    
    


