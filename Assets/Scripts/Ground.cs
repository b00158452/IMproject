using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        //choose a rando point
        int obstacleSpawnIndex = Random.Range(0, 4);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        // spawn the obstacle position
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

    }
}
