using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sharp : MonoBehaviour
{   
    Movement movementsc;
    private bool Stabbed;
    public Rigidbody a;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)) //|| rg.isKinematic == true)
        {
            UnStab();
        }
        }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            if (Stabbed)
                return;
            Stab();
            Stabbed = true;
            
            
        }
    }
    public void Stab()
    {
        a.isKinematic = true;
    }
    public void UnStab()
    {
        if (!Stabbed) return;

        StartCoroutine(UnStabCoroutine());
    }
    public IEnumerator UnStabCoroutine()
    {
        yield return new WaitForSeconds(0.2f);
        Stabbed = false;
    }
}
