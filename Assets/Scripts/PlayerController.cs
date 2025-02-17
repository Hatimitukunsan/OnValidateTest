using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform playerInitialPos;

    private void OnValidate()
    {
        if (playerInitialPos != null)
        {
            transform.position = playerInitialPos.position;
        }
    }
}
