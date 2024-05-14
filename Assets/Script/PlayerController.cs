using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Vector2 _move;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _velocidade;
    [SerializeField] float _moveY;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _move.x = Input.GetAxisRaw("Horizontal");
        // = Input.GetAxisRaw("Vertical");

        _rb.velocity = new Vector2(_move.x, 0);
    }
}