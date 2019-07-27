using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Time;


public class PlayerMovement : MonoBehaviour
{
    bool canJump=false;

    void Start(){

    }

    void Update(){
        if (Input.GetKey("left")){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-100f*Time.deltaTime,0));
        }

        else if (Input.GetKey("right")){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(100f*Time.deltaTime,0));
        }
        else if (Input.GetKeyDown("up") && canJump){
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,1000f*Time.deltaTime));
        }                 
        else{

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            canJump = true;
        }
    }

}
