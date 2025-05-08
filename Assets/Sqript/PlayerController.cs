using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 3.0f;

    private Rigidbody2D rbody2D;
    private float jumpFprce = 200f;//ジャンプの高さ
    private int jumpCount = 0;//ジャンプの回数

    private void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        // 右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += speed * transform.right * Time.deltaTime;
        }

        // 左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position -= speed * transform.right * Time.deltaTime;
        }
        //ジャンプする
        if (Input.GetKeyDown(KeyCode.Space) && this.jumpCount < 2)//２段ジャンプあり
        {
            this.rbody2D.AddForce(transform.up * jumpFprce);
            jumpCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;//地面に付いたらジャンプのカウントを0にする
        }
    }
}