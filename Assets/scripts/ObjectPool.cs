using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    private void Awake()
    {
        Instance = this;
    }

    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefrab;
        public int size;
    }

    public List<Pool> pools;

    public Dictionary<string, List<GameObject>> poolDictionary;
    void Start()
    {
        poolDictionary = new Dictionary<string, List<GameObject>>();

        foreach (Pool pool in pools)
        {
            List<GameObject> objectPool = new List<GameObject>();
            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefrab, new Vector3(i, 0, 0), Quaternion.identity);
                obj.SetActive(false);
                objectPool.Add(obj);
            }
            poolDictionary.Add(pool.tag, objectPool);
        }
    }

    public GameObject SpawnfromPool(string tag,  Vector3 position, Quaternion rotation, int index)
    {
        GameObject go = poolDictionary[tag][index];
        go.SetActive(true);
        go.transform.position = position;
        go.transform.rotation = rotation;
        return go;
    }

    public void DeactivateFromPool(string tag)
    {
        List<GameObject> go = poolDictionary[tag];
        {
            go.ForEach(g => g.SetActive(false));
        }
    }

    public void ActivateCube(string tag,int index){
        List<GameObject> go = poolDictionary[tag];
        go[index].SetActive(true);
    }
}
