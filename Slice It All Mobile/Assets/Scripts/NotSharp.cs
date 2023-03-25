using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotSharp : MonoBehaviour
{
    public Rigidbody a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Ground")
        {
            
            a.AddForce(new Vector3(100f, 500f, 0f));

        }
    }


}
