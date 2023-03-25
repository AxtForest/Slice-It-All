using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField]
    private GameObject WinPanel;
    public AudioSource WinSound;
    
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
        if (collision.gameObject.tag == "Sharp")
        {
            WinSound.Play();
            WinPanel.SetActive(true);
            Time.timeScale = 0;

        }
    }
}
