using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rg;
    [SerializeField]
    private Vector3 OnTork;
    [SerializeField]
    private Vector3 ArkaTork;
    public AudioSource KnifeSound;
    Sharp sharpSc;
    [SerializeField]
    private float MaxH = 1000f;
    
    //public bool Stabbed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) //|| rg.isKinematic == true)
        {
            //Touch touch = Input.GetTouch(0);
            //rg.isKinematic = false;
            //Jump();
            //Spin();
            //KnifeSound.Play();
            
            OnTouch();

        }
    }
    private void Jump()
    {

        //rg.AddForce(new Vector3(-300f, 800f, 0f)); //-500 1500
        if (gameObject.transform.position.y <= 20)
        {
            Vector3 force = new Vector3(-5f, 20f, 0f);

            rg.AddForce(Vector3.ClampMagnitude(force, MaxH), ForceMode.Impulse);
        }
    }
    private void Spin(int yon = 1)
    {
        Vector3 spinTorque = yon == 1 ? OnTork : ArkaTork; //on 270 arka 220

        rg.angularVelocity = Vector3.zero;
        rg.AddTorque(spinTorque, ForceMode.Acceleration);
    }
    private void OnTriggerEnter(Collider other)
    {

        //if (other.tag == "Ground")
        //{
        //    //if (Stabbed)
        //    //    return;
        //    //Stabbed = true;

           

        //    //Stab();
        //}
        //    else
        //    { }

        //    //if(collision.gameObject.tag == "Ground" && Input.GetKeyDown(KeyCode.Space))
        //    //{
        //    //    rg.isKinematic = false;

        //    //}
    }

    //public void Stab()
    //{
    //    rg.isKinematic = true;
    //}
        //private void UnStab()
        //{
        //    if (!Stabbed) return;

        //    StartCoroutine(UnStabCoroutine());
        //}

        //private IEnumerator UnStabCoroutine()
        //{
        //    yield return new WaitForSeconds(0.2f);
        //    Stabbed = false;
        //}
        public void OnTouch()
    {
        Touch touch = Input.GetTouch(0);
        rg.isKinematic = false;
        Jump();
        Spin();
        KnifeSound.Play();
        

    }

}
