using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class PlayerController2 : MonoBehaviour
{
    [SerializeField] private Transform playerInitialPos;

    private void OnValidate()
    {
        Debug.Log("OnValidate");
        if (playerInitialPos != null)
        {
            transform.position = playerInitialPos.position;
        }
    }

    private void Update()
    {
        if (playerInitialPos != null)
        {
            transform.position = playerInitialPos.position;
        }
    }

    private void Start()
    {
        Debug.Log("Start");
    }
}
