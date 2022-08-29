using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMushroom : MonoBehaviour
{
    private MushroomPooler mushroomPool;

    void Start()
    {
        mushroomPool = FindObjectOfType<MushroomPooler>();
    }

    private void OnDisable()
    {
        if (mushroomPool != null)
        {
            mushroomPool.ReturnGameObject(this.gameObject);
        }
    }
}
