using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    float spawnTime = 0;
    [SerializeField]
    float spawnTimeDefault = 5f;
    [SerializeField]
    float spawnTimeWide = 5f;
    [SerializeField]
    bool spawnFlug = false;

    private SpawnObjectManager spawnObjectManager;

    // Start is called before the first frame update
    void Start()
    {
        spawnObjectManager = SpawnObjectManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {             
    }

    public bool UpdateManagment()       //こっちをマネージャーから呼び出す
    {
        if (!spawnFlug)
        {
            SpawnTimeManager();

        }

        return spawnFlug;
    }



    public void SpawnTimeManager()
    {
        if (spawnTime <= 0f)
        {
            SetSpawnTime();

            spawnFlug = true;
        }
        else{
            spawnTime-=Time.deltaTime;
        }

    }

    void SetSpawnTime()
    {
        spawnTime = spawnTimeDefault + Random.Range(0, spawnTimeDefault);
    }

    public void Spawn(GameObject obj) {
        if(obj) Instantiate(obj,this.gameObject.transform.position,Quaternion.identity);
        spawnFlug = false;
    }
}
