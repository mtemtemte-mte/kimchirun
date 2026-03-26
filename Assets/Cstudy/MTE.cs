using UnityEngine;

    
public class MTE : MonoBehaviour
{
   public int hp = 318; //자숙절의 체력을 가진
    public int speed = 110000; //마하9 속도를 가진 
    public string MTEname = "뭉탱이"; //함부로 입에 담에서는 안되는 ㄷㄷㄷ
    private bool alive = true ;

    
        void Start()
    {
        
        
        Debug.Log ("얘 뭐가 좀 안되니?");
        Debug.Log ($"그의 스탯 체력: {hp}이다");
        Debug.Log ($"그의 스탯 속도: {speed}km 이다");
        
        
   
    }

    
 
    
}

