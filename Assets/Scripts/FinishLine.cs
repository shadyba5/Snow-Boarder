using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1.5f;
    [SerializeField] ParticleSystem finishEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScence", loadDelay);
            
        }
    }

    void ReloadScence()
    {
        SceneManager.LoadScene(0);
    }
}
