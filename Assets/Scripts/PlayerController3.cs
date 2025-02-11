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
        // ���͂��擾�iWASD / ���L�[�j
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // �ړ��ʂ��v�Z
        Vector3 move = new Vector3(moveX, moveY, 0).normalized * speed * Time.deltaTime;

        // Transform �𒼐ڕύX���Ĉړ�
        transform.position += move;
    }
}
