using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManger : MonoBehaviour
{
    public static GameManger instance;
    public int Lives;
    public Player player;
    public GameObject player2;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("GameManger Instance Created" + instance.name);
        }
        else
        {

            Destroy(gameObject);
        }
    }
    public void Start()
    {
        Lives = 1;
        SceneManager.LoadScene("Score");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("뭔 소리인 모르겠음");
            Lives = 1;
            Debug.Log("넘김");
        }
    }
}

