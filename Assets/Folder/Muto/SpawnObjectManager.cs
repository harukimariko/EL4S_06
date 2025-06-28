using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectManager : MonoBehaviour
{
    public List<GameObject> SpawmObjectList;    //生成するおぶじぇくとりすと

    public List<int> SpawnObjectID;                    //IDを管理するようSpawner個々人が時間を管理して、スポーンする時間になったらこのIDに対応するプレハブをSpawnerに送る

    public List<GameObject> spawnerList;            //フィールドに設置するスポナー管理用

    private static SpawnObjectManager _instance;
    public static SpawnObjectManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindAnyObjectByType<SpawnObjectManager>();
                if (_instance == null)
                {
                    GameObject go = new GameObject("SpawnObjectManager");
                    _instance = go.AddComponent<SpawnObjectManager>();
                }
            }
            return _instance;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        //スポナーの数だけIDを管理するリストを大きくする
        SpawnObjectID = new List<int>(spawnerList.Count);

        for (int i = 0; i < spawnerList.Count; i++)
        {
            SpawnObjectID.Add(0);
            SetSpawnID(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i=0; i<spawnerList.Count; i++) {
            Spawner sp = spawnerList[i].GetComponent<Spawner>();
            int target = SpawnObjectID[i];
            if (sp.UpdateManagment())
            {
                sp.Spawn(GetObject(target));
                SetSpawnID(i);
            }
        }
    }



    public GameObject GetObject(int id)
    {
        return SpawmObjectList[id];
    }

    void SetSpawnID(int i)
    {
        int target = Random.Range(0, SpawmObjectList.Count);
        SpawnObjectID[i] = target;
    }
}

