using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleRit : MonoBehaviour
{
    public ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        
        }
    public float slow = 0.9f;
    // Update is called once per frame
    void Update()
    {
        ParticleSystem.Particle[] p = new ParticleSystem.Particle[ps.particleCount + 1];
        int l = ps.GetParticles(p);
        for (int i = 0; i < l; i++)
        {
            Vector3 vel = p[i].velocity;
            p[i].velocity = vel * slow;
        }
        ps.SetParticles(p, l);
    }
}
