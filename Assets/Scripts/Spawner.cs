using UnityEngine;


public class Spawner : MonoBehaviour
{
    public float minSpawnTime = 1.0f;
    public float maxSpawnTIme = 0.3f;
    public GameObject[] buildingPefads;

    private void OnEnable()
    {

        Invoke("Spawn", 1.5f);

    }

    void Start()
    {
        Instantiate(buildingPefads[0], transform.position, Quaternion.identity);
    }


    void Spawn()
    {
        float randomtime = Random.Range(minSpawnTime, maxSpawnTIme);

        GameObject Randombuilding = buildingPefads[Random.Range(0, buildingPefads.Length)];
        Instantiate(Randombuilding, transform.position, Quaternion.identity);
        Invoke("Spawn", randomtime);
    }

    void MakeInstance()
    {
        GameObject randomBuilding = buildingPefads[Random.Range(0, buildingPefads.Length)];
        Instantiate(randomBuilding, transform.position, Quaternion.identity);


    }
}

