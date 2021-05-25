using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
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
            Destroy(other.gameObject);
        
        Debug.Log("SPIKES!!!");
        // This destroys the other game object
        // 

        // This respawns the player at 0,0
        // other.transform.position = new Vector2(0, 0);
    }
}
