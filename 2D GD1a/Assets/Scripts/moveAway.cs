using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAway : MonoBehaviour
{

    public Transform highlander;
    public float fleeSpeed;
    public float fleeDistance;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fleeDistance = Vector2.Distance(transform.position, highlander.transform.position);

        if (fleeDistance < 2)
        {
            Debug.Log("less than 2");
            transform.position = Vector2.MoveTowards(transform.position, highlander.transform.position, -fleeSpeed * Time.deltaTime);
        }
    }

    
}
