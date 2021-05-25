using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{

    public float moveSpeed = 7.0f;
    Rigidbody ballRigidBody;
    [SerializeField]
    private AudioSource _Blocked;


    // Start is called before the first frame update
    void Start()
    {
        ballRigidBody = GetComponent<Rigidbody>();
        _Blocked = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        Movements();
    }

    void Movements()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        Vector3 newVelocity = new Vector3(inputVertical * moveSpeed, -1.0f, inputHorizontal * -moveSpeed);
        ballRigidBody.velocity = newVelocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            _Blocked.Play();
        }
    }
}
