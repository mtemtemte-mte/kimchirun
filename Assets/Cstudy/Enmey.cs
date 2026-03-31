using UnityEngine;


public class Enmey : MonoBehaviour
{
  Gamemanger GameMgrObject;
  public void TakeDamnge(int damnge)
  {
    Debug.Log("뭉탱이" + damnge);
    
  }


  void Start()
  {
    TakeDamnge(10);
    Debug.Log("state :" + GameMgrObject.gameState);
  }

}

