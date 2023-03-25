using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;
using UnityEngine.UI;
public class Sliceable : MonoBehaviour
{
    public Material materialSlicedSide;
    public float explosionForce;
    public float explosionRadius;
    public Text scoreText;
    public int Score = 0;
    public Text FinalScoreText;
    public Text LoseScoreText;
    public AudioSource CutSound;
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
        if (other.gameObject.CompareTag("SliceAble"))
        {
            
            SlicedHull sliceobj = Slice(other.gameObject, materialSlicedSide);
            GameObject SlicedObjTop = sliceobj.CreateUpperHull(other.gameObject, materialSlicedSide);
            GameObject SlicedObjDown = sliceobj.CreateLowerHull(other.gameObject, materialSlicedSide);
            Destroy(other.gameObject);
            AddComponent(SlicedObjTop);
            AddComponent(SlicedObjDown);
            CutSound.Play();
            scoreText.text = Score.ToString();
            LoseScoreText.text = Score.ToString();
            Score++;
            FinalScoreText.text = (Score-1).ToString();

                
        }
    }
    private SlicedHull Slice(GameObject obj, Material mat)
    {
        return obj.Slice(transform.position, transform.right, mat);
    }
    void AddComponent(GameObject obj)
    {
        obj.AddComponent<BoxCollider>();
        var rigidbody = obj.AddComponent<Rigidbody>();
        rigidbody.useGravity = true;
        rigidbody.isKinematic = false;
        rigidbody.AddExplosionForce(explosionForce, obj.transform.position, explosionRadius);
        obj.tag = "SliceAble";
        Destroy(obj, 2f);
    }
}
