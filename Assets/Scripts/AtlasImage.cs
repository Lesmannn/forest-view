using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class AtlasImage : MonoBehaviour
{
    [SerializeField]
    private SpriteAtlas spriteAtlas;
    [SerializeField]
    private string nameAtlas;

    private void Start()
    {
        GetComponent<Image>().sprite = spriteAtlas.GetSprite(nameAtlas);
    }
}
