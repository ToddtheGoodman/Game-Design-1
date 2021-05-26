using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{

    public float despawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        despawnTimer = Random.Range(3, 10);
    }

    // Update is called once per frame
    void Update()
    {
        despawnTimer -= Time.deltaTime;
        // despawnTimer = despawnTimer - Time.deltaTime;
        if (despawnTimer < 0)
        {
            Destroy(gameObject);
        }


    }
}
