using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawner = true;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;

    [SerializeField] Attacker[] enemyPrefabs;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawner)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttackers();
        }
    }

    public void StopSpawning()
    {
        spawner = false;
    }

    private void SpawnAttackers()
    {
        var index = Random.Range(0, enemyPrefabs.Length);
        Spawn(enemyPrefabs[index]);
    }

    private void Spawn(Attacker attacker)
    {
        Attacker newAttacker = Instantiate(attacker, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
