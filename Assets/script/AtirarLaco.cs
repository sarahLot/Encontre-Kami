using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarLaco : MonoBehaviour
{
    [SerializeField] Transform player;
    void Update()
    {
        Vector2 posicaoDoMause= Main.Camera.ViewportToWorldPoint(Input.mousePosition);

        Vector2 direction = (player.position - posicaoDoMause);
    }
}
