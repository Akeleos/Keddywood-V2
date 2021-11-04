using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    [SerializeField] int yumakCount;
    [SerializeField] int SpawnX;
    [SerializeField] int SpawnZ;
    private float spawnTime=3f;
    public int posXrange, negXrange;
    public int posZrange, negZrange;
    private void Start()
    {

        StartCoroutine(spawnObj(spawnTime));
    }
    
    

    IEnumerator spawnObj( float spawnTime)
    {
 
        while (true)
        {

            SpawnX = Random.Range(negXrange, posXrange);
            SpawnZ = Random.Range(negZrange, posZrange);
            ObjectPool.Instance.GetPoolObject(SpawnX, SpawnZ);
            yield return new WaitForSeconds(spawnTime);
            yumakCount++;

        }

    }

}
