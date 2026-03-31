using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class Gamemanger : MonoBehaviour
{







    public enum GameState
    {
        play, Paused, gameoVER, clear, 뭉탱이, 죠니죠스타

    }
     private GameState currentState = GameState.뭉탱이;
    public Enmey enmy;
    void Start()
    {
        enmy.TakeDamnge(13);
    }


    void Update()
    {

        Keyboard curKey = Keyboard.current;
        if (curKey != null)
        {
            if (curKey.pKey.wasPressedThisFrame)
            {
                 currentState = GameState.Paused;
            }
             



        }
    }
}

