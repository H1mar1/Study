using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Camera))]
public class GameController1 : MonoBehaviour
{
    GameObject playerObj;
    PlayerController player;
    Transform playerTransform;

    private void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("player");
        player = playerObj.GetComponent<PlayerController>();
        playerTransform = playerObj.transform;
    }

    private void LateUpdate()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        //â°ï˚å¸ÇæÇØí«ê’
        transform.position = new Vector3(playerTransform.position.x, transform.position.y, transform.position.z);
    }
}
