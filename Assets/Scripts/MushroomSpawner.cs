using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    public GameObject objPrefab;

    private List<GameObject> _mushroomPool = new List<GameObject>();
    
    void FixedUpdate(){
        InstantiateMushroom(objPrefab, _mushroomPool);
    }

    void InstantiateMushroom(GameObject prefab, List<GameObject> pool)
    {
        GameObject mushroom = pool.Find(i => !i.gameObject.activeSelf);
        if (mushroom == null)
        {
            mushroom = Instantiate(prefab, transform.position, Quaternion.identity);
            pool.Add(mushroom);
        }
        mushroom.transform.position = transform.position;
        mushroom.gameObject.SetActive(true);
    }
}
