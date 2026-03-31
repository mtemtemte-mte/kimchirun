
using UnityEngine;
using UnityEngine.InputSystem;


public class num : MonoBehaviour
{
    int tyuCount=0;
    void Start()
    {
        Debug.Log("================");
        Debug.Log("숫자 맞추기 게임");
        Debug.Log("1~5 숫자 맞춰");
        Debug.Log("[1][2][3][4][5]키 눌러");
        Debug.Log("====================");

    }


    void Update()
    {
        int input = -1;
        Keyboard key = Keyboard.current;

        if (key.numpad1Key.wasPressedThisFrame) input = 1;
        if (key.numpad2Key.wasPressedThisFrame) input = 2;
        if (key.numpad3Key.wasPressedThisFrame) input = 3;
        if (key.numpad4Key.wasPressedThisFrame) input = 4;
        if (key.numpad5Key.wasPressedThisFrame) input = 5;

        if (input != -1)
        {
            Debug.Log("input : " + input);
            CheckAnswer(input);

        }
    }

    private void CheckAnswer(int input)
    {
      tyuCount++;
        Debug.Log($"입력:{input},시도 회수{tyuCount}");

    }
}

