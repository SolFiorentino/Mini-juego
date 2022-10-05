using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovement : MonoBehaviour
{

    public Rigidbody _rigidbody;

    public float forceMultiplier;
    public float jumpForce;
    public bool canJump;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

        canJump = true;

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.D))


            _rigidbody.AddForce(forceMultiplier, 0f, 0f);



        if (Input.GetKey(KeyCode.A))
        {

            _rigidbody.AddForce(-forceMultiplier, 0f, 0f);

        }

        if (Input.GetKey(KeyCode.W))
        {

            _rigidbody.AddForce(0f, 0f, forceMultiplier);

        }

        if (Input.GetKey(KeyCode.S))
        {

            _rigidbody.AddForce(0f, 0f, -forceMultiplier);

        }


        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {

            _rigidbody.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);

            canJump = false;

            Debug.Log("JUMP>>");

        }
    }

    private void OnCollisionEnter(Collision datosdelchoque)

    {

        Debug.Log("collision with:" + datosdelchoque.gameObject.name);
        Debug.Log("collision with:" + datosdelchoque.gameObject.tag);

        
            if (datosdelchoque.gameObject.CompareTag("plataforma")) {


               canJump = true;
            }


            if (datosdelchoque.gameObject.CompareTag("target")) {

            ScoreManager.ScoreValue += 1;

            Destroy(datosdelchoque.gameObject);


            }

                
        
   
    
    }


} 


       

       


   
