using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectManager : MonoBehaviour
{
    public List<GameObject> SpawmObjectList;    //�������邨�Ԃ������Ƃ肷��

    public List<int> SpawnObjectID;                    //ID���Ǘ�����悤Spawner�X�l�����Ԃ��Ǘ����āA�X�|�[�����鎞�ԂɂȂ����炱��ID�ɑΉ�����v���n�u��Spawner�ɑ���

    public List<GameObject> spawnerList;            //�t�B�[���h�ɐݒu����X�|�i�[�Ǘ��p

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
        //�X�|�i�[�̐�����ID���Ǘ����郊�X�g��傫������
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

