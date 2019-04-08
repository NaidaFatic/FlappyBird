using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public GameObject prefab;
    private float spawnY, spawnX;

	// Use this for initialization
	void Start ()
    {
        SpawnCloud(7);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void SpawnCloud(float spawnX)
    {
        spawnY = Random.Range(-2f,3f);
    
        Instantiate(prefab, new Vector2(spawnX, spawnY), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Cloud>()!=null)
        {
            SpawnCloud(Random.Range(17,19));
        }
    }
}
