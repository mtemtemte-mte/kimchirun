using UnityEngine;


public class Destroyer : MonoBehaviour
{
    private Camera mainCamera;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        mainCamera = Camera.main;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        float cameraLeftEdge = -mainCamera.transform.position.x -
        mainCamera.orthographicSize * mainCamera.aspect;
        Debug.Log(mainCamera.aspect);
        float objectRighEdge = spriteRenderer.bounds.max.x;


        if (objectRighEdge < cameraLeftEdge)
        {
            Destroy(gameObject);
        }
    }
}

