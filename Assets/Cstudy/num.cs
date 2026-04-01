
using UnityEngine;
using UnityEngine.InputSystem;


public class num : MonoBehaviour
{
    int tyuCount = 0;
    int answer = 4;
    const int maxtry = 5;
    bool isGameOver = false;

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
        if (isGameOver) return;

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
        if (input == answer)
        {
            Debug.Log("정답");
            isGameOver = true;
            return;
        }
        if (tyuCount >= maxtry)
        {
            Debug.Log($"당신의 하찮은 실력으로 당신은 패배했습니다 답은 {answer}");
            isGameOver = true;
            return;
        }
        if (input < answer)
        {
            Debug.Log("더 큰 값을 입력해라 이 빡대가리야🫤");
        }
        else
        {
            Debug.Log("아이고난1 아이고난2 더 작은 값을 입력해주세요🫤");
        }

    }
}

