using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class PlayerController3 : MonoBehaviour
{
    [SerializeField] private Transform playerInitialPos;

    private float speed = 5f;

    private void Update()
    {
        if (!Application.isPlaying && playerInitialPos != null)
        {
            transform.position = playerInitialPos.position;
        }

        Move();
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    private void Move()
    {
        // 入力を取得（WASD / 矢印キー）
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // 移動量を計算
        Vector3 move = new Vector3(moveX, moveY, 0).normalized * speed * Time.deltaTime;

        // Transform を直接変更して移動
        transform.position += move;
    }
}
