using UnityEngine;

public class RainbowColor : MonoBehaviour
{
    public float speed = 1.0f;      // 색 바뀌는 속도 (크면 빠름)
    public float saturation = 1.0f; // 채도 (1이 가장 선명)
    public float brightness = 1.0f; // 밝기 (1~2로 하면 더 반짝)

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        if (rend == null)
            rend = GetComponentInChildren<Renderer>();
    }

    void Update()
    {
        // 시간에 따라 Hue(색상)만 계속 순환
        float hue = Mathf.Repeat(Time.time * speed, 1.0f);

        Color rainbowColor = Color.HSVToRGB(hue, saturation, brightness);

        // Emission(발광)도 같이 주면 더 반짝반짝 빛남
        rend.material.color = rainbowColor;
        rend.material.SetColor("_EmissionColor", rainbowColor * 2.0f); // * 숫자 = 발광 세기
    }
}