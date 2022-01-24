using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnPoints;
	public GameObject blockPrefab;
    private float start=0.05f;
    private float delay=4f;
    void Start()
    {
        InvokeRepeating("SpawnBlocks",start,delay);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void SpawnBlocks ()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);
        Debug.Log(randomIndex);

		for (int i = 0; i < spawnPoints.Length; i++)
		{
			if (randomIndex != i)
			{
				Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
			}

		}
	}
}
