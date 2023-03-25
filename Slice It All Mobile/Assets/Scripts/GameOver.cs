using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject Panel;
    public AudioSource GameOverSound;
    public GameObject scoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Sharp")
        {
            GameOverSound.Play();
            Panel.SetActive(true);
            scoreTxt.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
