using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawn : MonoBehaviour
{

    public GameObject miniHighlander;
    
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {
        var spawnPos = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
        Instantiate(miniHighlander, spawnPos, Quaternion.identity);
    }

}
