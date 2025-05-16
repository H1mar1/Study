using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 3.0f;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameManager gameManager;

    private Rigidbody2D rbody2D;
    private float jumpForce = 200f;//�W�����v�̍���
    private int jumpCount = 0;//�W�����v�̉�

    private void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        MovingPlayer();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;//�n�ʂɕt������W�����v�̃J�E���g��0�ɂ���
        }
    }

    private void MovingPlayer()
    {
        // �E�Ɉړ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += speed * transform.right * Time.deltaTime;
        }

        // ���Ɉړ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position -= speed * transform.right * Time.deltaTime;
        }
        //�W�����v����
        if (Input.GetKeyDown(KeyCode.Space) && this.jumpCount < 3)//3�i�W�����v����
        {
            this.rbody2D.AddForce(transform.up * jumpForce);
            jumpCount++;
        }

        //��������Q�[���I�[�o�[
        if (player.transform.position.y < -6) 
        {
            gameManager.GameOver();
        }
    }
}