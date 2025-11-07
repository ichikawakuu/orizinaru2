using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 着弾SE
    public AudioClip BomSE;
    AudioSource audioSource;

    // 爆発エフェクト
    public GameObject explotion;
    GameObject lastExplotion;

    public GameObject BomSEPrefab;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        // 着弾時爆発させる
        audioSource.PlayOneShot(BomSE);
        Instantiate(BomSEPrefab);
        lastExplotion = Instantiate(explotion, transform.position, transform.rotation);
        Destroy(gameObject, 0.01f);
        Destroy(lastExplotion, 1f);
    }


}
