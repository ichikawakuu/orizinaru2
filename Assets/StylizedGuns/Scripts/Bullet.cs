using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // âπÇì¸ÇÍÇÈïœêî
    public AudioClip SE;
    AudioSource audioSource;

    public GameObject explotion;
    GameObject lastExplotion;

    public GameObject BomSE;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            return;
        }
        //audioSource.PlayOneShot(SE);
        Instantiate(BomSE);

        lastExplotion = Instantiate(explotion, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(lastExplotion, 1f);
    }



}
