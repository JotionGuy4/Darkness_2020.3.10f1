using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucketAudioScript : MonoBehaviour
{
    public AudioSource soundSource;
    // Start is called before the first frame update
    void Start()
    {
        soundSource = GetComponent<AudioSource>();

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Bucket Audio Script detected collision");
            soundSource.Play();
        }
    }
}





