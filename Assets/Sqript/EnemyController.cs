using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Transform playerTr;//プレイヤーのTransform
    [SerializeField] float speed;//敵の動くスピード

    private void Start()
    {
        //プレイヤーのTransformを所得
        playerTr = GameObject.FindGameObjectWithTag("player").transform;
    }

    private void Update()
    {
        //プレイヤーとの教理が0.1未満になったらそれを実行しない
        if (Vector2.Distance(transform.position, playerTr.position) < 0.1f)
            return;

        //プレイヤーに向けて動く
        transform.position = Vector2.MoveTowards(
            transform.position, new Vector2(playerTr.position.x, playerTr.position.y), speed * Time.deltaTime);
    }
}