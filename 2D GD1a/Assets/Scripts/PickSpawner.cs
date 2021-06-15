using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickSpawner : MonoBehaviour
{

    public GameObject pickUp;

    //public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var spawnPos = new Vector2(Random.Range(-8f, 8f), Random.Range(-4.5f, 4.5f));

        Instantiate(pickUp, spawnPos, Quaternion.identity);   
    }

}
