using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl2d : MonoBehaviour
{

    public float _speed = 7f;
    private Rigidbody2D _rigbody;
    public float JumpForce = 7; 
    // Start is called before the first frame update
    private void Start()
    {
        _rigbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        var _move = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(_move * _speed * Time.deltaTime, 0, 0);
        if(Input.GetButtonDown("Jump"))
        {
            _rigbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

    }
}
