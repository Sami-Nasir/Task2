using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=5.0f;
    public float horizontalInputspeed= 6.0f;
    private float horizontalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position.x < -14){
            transform.position =new Vector3(-12, transform.position.y, transform.position.z);
        }else if(transform.position.x > 14){
            transform.position =new Vector3(12, transform.position.y, transform.position.z);
        }
        horizontalInput= Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right* horizontalInputspeed* Time.deltaTime *horizontalInput);
        
    }

}
