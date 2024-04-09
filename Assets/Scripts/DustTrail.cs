using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowBoardEffect;

    [SerializeField] int particlesBaseSpeedLow = 5;
    [SerializeField] int particlesBaseSpeedhigh = 35;
    [SerializeField] int particlesBoostSpeedLow = 15;
    [SerializeField] int particlesBoostSpeedhigh = 75;


    void Start()
    {

    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            snowBoardEffect.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {

            snowBoardEffect.Stop();
        }
    }
}
