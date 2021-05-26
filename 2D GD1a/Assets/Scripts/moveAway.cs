using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAway : MonoBehaviour
{

    public Transform runTarget;
    public float moveSpeed;
    public float runRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        runRange = Vector2.Distance(transform.position, runTarget.position);

        if (runRange < 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, runTarget.position, -moveSpeed * Time.deltaTime);
        }
    }
}
