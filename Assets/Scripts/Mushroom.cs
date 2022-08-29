using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public float upForce = 1f;
    public float sideForce = .1f;

    private float _despawnTimer = 0f;
    private float _despawnDelay = 3f;

    private void OnEnable()
    {
        _despawnTimer = 0f;
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce / 2f, upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce, yForce, zForce);

        GetComponent<Rigidbody>().velocity = force;
    }

    void Start()
    {
        
    }

    private void Update()
    {
        _despawnTimer += Time.deltaTime;
        if (_despawnTimer > _despawnDelay)
        {
            gameObject.SetActive(false);
            _despawnTimer = 0;
        }
    }
}
