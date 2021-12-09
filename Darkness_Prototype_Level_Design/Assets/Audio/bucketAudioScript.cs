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

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            soundSource.Play();
        }
    }
}





