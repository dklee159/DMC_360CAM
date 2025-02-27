using System.Collections;
using UnityEngine;


public class LightControll : MonoBehaviour
{
    
    public ParticleSystem particle;
    

    // Start is called before the first frame update
    void Start()
    {
        particle.Stop();
    }

    void OnTriggerEnter()
    {
        particle.Play();
        StartCoroutine(stopparticle());
    }
    IEnumerator stopparticle()
    {
        yield return new WaitForSeconds(.4f);
        particle.GetComponent<ParticleSystem>().enableEmission = false;
    }
}

