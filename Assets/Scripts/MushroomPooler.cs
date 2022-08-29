using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomPooler : MonoBehaviour
{
	[SerializeField]
	private GameObject objPrefabs;
	[SerializeField]
	private int createOnStart;

	private List<GameObject> poolsObj = new List<GameObject>();

	private void Start()
	{
		
		for (int x = 0; x < createOnStart; x++)
		{
			CreateNewObject();
		}
	}
    GameObject CreateNewObject()
	{
		GameObject obj = Instantiate(objPrefabs);
		obj.SetActive(false);
		poolsObj.Add(obj);

		return obj;
	}
	public GameObject GetObject()
	{
		GameObject obj;
		if (poolsObj.Count > 0)
        {
			obj = poolsObj.Find(x => x.activeInHierarchy == false);
			if (obj == null)
			{
				obj = CreateNewObject();
			}
			obj.SetActive(true);
			return obj;
		}
		else
        {
			obj = Instantiate(objPrefabs);
			return obj;
        }
	}
	public void ReturnGameObject(GameObject go)
    {
		//poolsObj.Add(go);
		go.SetActive(false);
    }
}
