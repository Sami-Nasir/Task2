using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
   // Start is called before the first frame update
    public float speed=5f;
    private float x=1;
       void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= new Vector3(transform.position.x,transform.position.y,x);
        x--;
    }
}
