using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Animator Anim;
    int _walkParam;
    public bool PlayerControllable = true;

    Rigidbody2D _rb;

    public float Speed;

    Vector2 _movement;

    float _horizontalMove;

    Vector3 _faceRight = new Vector3(0f, 180f, 0f);

    public float JumpSpeed = 5f;

    public static PlayerController Player;

    public AudioSource audioS;

    public AudioClip jump;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _walkParam = Animator.StringToHash("Walking");
        if (Player != null && Player != this)
            Destroy(this.gameObject);
        else 
            Player = this;
    }

    void FixedUpdate()
    {
        if (PlayerControllable)
        {
                _horizontalMove = Input.GetAxis ("Horizontal");
                if (_horizontalMove > 0)
                    transform.eulerAngles = _faceRight;
                else if (_horizontalMove < 0)
                    transform.eulerAngles = Vector3.zero;


                 _movement = new Vector2(_horizontalMove * Speed, _rb.velocity.y);

                if (_rb.velocity.y == 0)
                {
                    if (Input.GetButton("Jump"))
                    {
                        _movement = new Vector2(_horizontalMove * Speed, 5f);
                        audioS.PlayOneShot(jump);
                    }
                        
                }
                _rb.velocity = _movement;
        }
    }

    void Update ()
    {
        if (_rb.velocity.x != 0)
            Anim.SetBool(_walkParam, true);
        else
            Anim.SetBool(_walkParam, false);
    }
}
