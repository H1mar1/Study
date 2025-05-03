using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 3.0f;
    private void Update()
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
    }
}