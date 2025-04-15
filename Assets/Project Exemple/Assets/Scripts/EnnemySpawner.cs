using UnityEngine;
using System.Collections;

public class EnnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float delay = 3f;
    public float delayRange = 2f;

    public float posRange = 50f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
            float effectiveDelay = delay + Random.Range(-delayRange, delayRange);
            Vector3 spawnPos = new Vector3(this.transform.position.x + Random.Range(-posRange, posRange), this.transform.position.y, this.transform.position.z);
            Instantiate(enemy, spawnPos, enemy.transform.rotation);
            yield return new WaitForSeconds(effectiveDelay);
        }
    }
}
