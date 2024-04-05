using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKami : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rig;
    
    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 moveValue = new Vector2(Input.GetAxis("HorizontalKami"), Input.GetAxis("VerticalKami"));
        rig.AddForce(moveValue * speed, ForceMode2D.Force);
    }
}
