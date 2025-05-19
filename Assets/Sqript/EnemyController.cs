using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    Transform target;//追跡する対称（プレイヤー）
    [SerializeField]
    private float speed;//移動速度

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();//Rigidbody2Dを所得
    }

    private void Update()
    {
        if (target == null) return;

        //プレイヤーの方向を取得
        Vector2 direction = (Vector2)target.position - rb.position;
        direction.Normalize();

        //前進
        rb.linearVelocity = Vector2.left * speed;
    }
}