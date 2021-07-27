using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedExplosion : MonoBehaviour
{
    private float timer  = 0;

    public ParticleSystem explosion;
    public float timeToExplosion = 10;

    void Start()
    {
        if (explosion == null) 
        {
            Debug.LogError("Explosion field is not assigned");
            Debug.Break();
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timeToExplosion) 
        {
            explosion.Play();
        }
        
    }
}
