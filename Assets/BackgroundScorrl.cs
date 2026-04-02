using UnityEngine;


public class BackgroundScorrl : MonoBehaviour
{
    public float scrollSpead = 0.01f;
    private Material Mat;
    void Start()
    {
        Mat = GetComponent<MeshRenderer>().material;
    }


    void Update()
    {
        //Mat.SetTextureOffset("-BaseMap",new Vector2(scrollSpead,0));
        float offset = scrollSpead * Time.deltaTime;
        Mat.mainTextureOffset += new Vector2(offset, 0);

    }
}
