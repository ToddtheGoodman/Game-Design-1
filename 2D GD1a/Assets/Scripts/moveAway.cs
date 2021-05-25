using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAway : MonoBehaviour
{

    public Transform player;
    public float moveSpeed, range;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        range = Vector2.Distance(transform.position, player.position);
        if (range < 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -1 * moveSpeed * Time.deltaTime);
        }
        
        
    }
}
