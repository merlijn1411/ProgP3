using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getpickup : MonoBehaviour
{
    //deze code is voor de coin
    public AudioClip coin;
    AudioSource aScorce;
    GameObject obj;
    private KeepScore scoreScript;
    private ParticleSystem ps;
    void Start()
    {
        aScorce =GetComponent<AudioSource>(); // get component once @ Start more efficient.
        scoreScript = FindObjectOfType<KeepScore>();
        ps = GetComponent<ParticleSystem>();
        ps.Stop();

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        if (other.tag == "Player")
        {
            Destroy(gameObject, 0.5f);
            aScorce.clip = coin;
            scoreScript.AddScore(5);
            ps.Play();
            aScorce.Play();
        }
    }


}
