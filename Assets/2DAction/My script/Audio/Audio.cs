using UnityEngine;

public class Audio : MonoBehaviour
{
   [SerializeField] AudioClip _se;
    private AudioSource _Adi;

    void Start()
    {
        _Adi = GetComponent<AudioSource>();
    }

    // ぶつかった時に音を鳴らす
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _Adi.PlayOneShot(_se);
    }
}