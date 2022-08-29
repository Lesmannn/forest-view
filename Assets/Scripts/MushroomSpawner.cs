using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    [SerializeField]
    private float timeSpawn;
    private float timeSinceSpawn;
    private MushroomPooler mushroomPool;

    private void Start()
    {
        mushroomPool = FindObjectOfType<MushroomPooler>();
    }
    private void Update()
    {
        GameObject newPool = mushroomPool.GetObject();
        newPool.transform.position = this.transform.position;
    }
}
