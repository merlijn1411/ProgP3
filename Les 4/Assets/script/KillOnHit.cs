using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class KillOnHit : MonoBehaviour
{
    public string targetTag;
    public GameObject effect;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            Destroy(coll.gameObject, 0.1f);

            GameObject expl = Instantiate(effect, coll.transform.position, Quaternion.identity);
            Destroy(expl, 2f);
            audioSource.Play();
        }
        
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == targetTag)
        {

            Destroy(coll.gameObject, 0.1f);

            GameObject expl = Instantiate(effect);
            Destroy(expl, 2f);
            audioSource.Play();
        }
    }
}

