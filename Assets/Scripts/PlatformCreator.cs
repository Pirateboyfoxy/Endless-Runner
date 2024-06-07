using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCreator : MonoBehaviour
{
    public GameObject platformPrefab;

    float randomHeight = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("SpawnPlatforms", 1.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPlatforms()
    {
        Instantiate(platformPrefab, new Vector2(12, Random.Range(-randomHeight, randomHeight)), Quaternion.identity);
    }

    
}
