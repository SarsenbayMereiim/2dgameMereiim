using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroomController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private KeyCode _JumpButton;
    [SerializeField] private float _jumpForce;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputDir = Input.GetAxis("Horizontal");

        transform.position = Vector3.Lerp(transform.position, new Vector3(inputDir, transform.position.y, 0), Time.deltaTime * _moveSpeed);

        if (Input.GetKeyDown(_JumpButton))
        {
            _rb.AddForce(Vector2.up * _jumpForce);
        }
    }
}
