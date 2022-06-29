using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichAudio : MonoBehaviour
{
    [SerializeField] AudioClip _se;
    private AudioSource _Adi;

    void Start()
    {
        _Adi = GetComponent<AudioSource>();
    }

    // ぶつかった時に音を鳴らす
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _Adi.PlayOneShot(_se); 
    }
}