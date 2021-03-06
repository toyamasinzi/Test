using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board2 : MonoBehaviour
{
    [SerializeField] GameObject _board;
    [SerializeField] GameObject _dstoroy;
    [SerializeField] AudioClip _se;
    private AudioSource _Adi;

    private bool _Audio = false;
    private bool _played = true;
    void Start()
    {
        _Adi = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (_Audio && _played)
        {
            _Adi.PlayOneShot(_se);
            _played = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_board.GetComponent<Board>()._key == true)
        {
            _dstoroy.SetActive(false);
            _Audio = true;
        }
    }

}