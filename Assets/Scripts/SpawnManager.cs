using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaclePrefab;
    [SerializeField]
    private float spawnTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Vector2 posToSpawn = new Vector2(15, Random.Range(-2.7f, 2.7f));
            Instantiate(obstaclePrefab, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }


    }
}
