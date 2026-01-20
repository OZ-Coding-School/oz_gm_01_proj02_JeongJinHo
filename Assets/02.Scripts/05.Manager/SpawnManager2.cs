using System.Collections;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject spawnEffect;
    [SerializeField] private float timer = 2f;
    [SerializeField] private float effectDelay = 2f;
    [SerializeField] private float spawnInterval = 5f;
    [SerializeField] private int spawnCount = 3;

    //private void Update()
    //{
    //    GameObject effect = Instantiate(spawnEffect, transform.position, Quaternion.identity);
    //    Destroy(effect, effectDelay);

    //    for(int i = 0; i < spawnCount; i++)
    //    {
    //        GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);


    //    }
    //}
    private void Start()
    {
        StartCoroutine(Spawn2());
    }
    IEnumerator Spawn()
    {
        
        GameObject effect = Instantiate(spawnEffect, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(effectDelay);

        for (int i = 0; i < spawnCount; i++)
        {
            GameObject spawn = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }

    }
    IEnumerator Spawn2()
    {
        float timer = 60f;
        float startTime = Time.time;
        

        while (Time.time < startTime + timer)
        {
            GameObject effect = Instantiate(spawnEffect, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(effectDelay);

            int randomSpawn = Random.Range(2, 8);

            for(int i = 0; i < randomSpawn; i++)
            {
                //Vector3 spawn=new Vector3(Random.Range(-5,5),0,Random.Range(-5,5));
                Vector3 spawn=new Vector3(Random.Range(-10,10), Random.Range(-10, 10),0);
                Instantiate(enemyPrefab, transform.position+spawn, Quaternion.identity);
                //yield return new WaitForSeconds(0.1f);
            }
            yield return new WaitForSeconds(spawnInterval);
        }
        
    }
}
