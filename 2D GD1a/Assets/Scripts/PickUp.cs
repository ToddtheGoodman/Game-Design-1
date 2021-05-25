using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {       
        if (other.gameObject.CompareTag("Player"))
        {            
            // increase my scoreValue
            GameObject.Find("Canvas").GetComponent<Score>().scoreValue += 1;
            Debug.Log("Pick Up!");
            Destroy(gameObject);
        }       
    }
}
