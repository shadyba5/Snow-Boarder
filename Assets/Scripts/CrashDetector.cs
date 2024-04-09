using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip CrashSFX;

    bool crashSFXplayed = false;
    bool particleEffectPlayed = false;
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
        if(other.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().DisableControls();
            if (!crashSFXplayed)
            {
                GetComponent<AudioSource>().PlayOneShot(CrashSFX);
                crashSFXplayed=true;
            }
            if (!particleEffectPlayed)
            {
                crashEffect.Play();
                particleEffectPlayed = true;
            }
            Invoke("ReloadScence", loadDelay);
        }
    }
    
    void ReloadScence()
    {
        SceneManager.LoadScene(0);
    }
     
}
