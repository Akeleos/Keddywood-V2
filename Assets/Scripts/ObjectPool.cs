using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private Queue<GameObject> pooledObject;
    [SerializeField] private GameObject yumakPref;
    [SerializeField] public int poolSize;


    public static ObjectPool Instance;

    private void Awake()
    {
        Instance = this;
        pooledObject = new Queue<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(yumakPref);
            obj.SetActive(false);

            pooledObject.Enqueue(obj);
        }
    }


    public GameObject GetPoolObject(int x,int z)
    {
        GameObject obj = pooledObject.Dequeue();
        obj.transform.position = new Vector3(x,obj.transform.position.y,z);
        obj.SetActive(true);
        pooledObject.Enqueue(obj);

        return obj;
    }

    
}
