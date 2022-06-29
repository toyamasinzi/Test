using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destory : MonoBehaviour
{
    [SerializeField] string _Scene = "GameOver";
    void OnCollisionEnter2D(Collision2D collision)
    {
        //衝突した相手にplayer1またはplayer2タグが付いてるとき
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            //Destroy(collision.gameObject, 0.01f);
            SceneManager.LoadScene(_Scene);
        }
    }

}
