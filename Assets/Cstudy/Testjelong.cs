using UnityEngine;


public class Testjelong : MonoBehaviour
{

    void Start()
    {
        string[] enmies = new string[2];

        enmies[1] = "고블린";
        enmies[0] = "슬라임";
        enmies[2] =  "오크";

        int i = 1;
        Debug.Log($"{i}번의 적 등장!");

        i++;
        Debug.Log($"{i}번의 적 등장!");

        i++;
        Debug.Log($"{i}번의 적 등장!");


        Debug.Log("-----------------");

        for (int j = 1; i <= 3; j++)
        {
            Debug.Log($"{i}번의 적 등장!");
        }
        
    }
    


    void Update()
    {

    }
}

