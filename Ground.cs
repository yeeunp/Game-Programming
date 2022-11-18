using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    // Start is called before the first frame update
    public void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.1f,0,0);
        if(transform.position.x <-19)
        {
            transform.position= new Vector2(0,0);
        }
    }
}
