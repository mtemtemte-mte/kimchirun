using UnityEngine;


public class Sample : MonoBehaviour
{
    int playerHP= 100;

    
    void Start()
    {
        Debug.Log ("뭉탱이로있다 유리게슝~");
        Debug.Log ("뭉탱이가 유리계슝 했습니다 : "+ playerHP);
        Debug.Log ($"뭉탱이가 유리계슝한 결과는 {playerHP}입니다");
        Debug.Log ("뭉탱이가 유리계슝한 결과는 {playerHP}입니다");
        Debug.Log (playerHP);
        Debug.LogWarning("뭉탱이가 너무 커요!");
        Debug.LogError("뭉탱이가 지구보다 커졌어!~");
        
    }
    void Update()
    {
        Debug.LogError("얘! 뭐가 좀 안되니?");
    }



}

