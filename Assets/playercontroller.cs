using UnityEngine;
public class playercontroller : MonoBehaviour
{
   public Rigidbody rb;
   public float forwardforce=200f;
   public float sideforce=500f;
   void FixedUpdate()
   {
     
     if(Input.GetKey("w"))
     {
       rb.AddForce(0,0,500 * Time.deltaTime);
     }
     if(Input.GetKey("d"))
     {
       rb.AddForce(500 * Time.deltaTime,0,0);
     }
     if(Input.GetKey("a"))
     {
       rb.AddForce(-sideforce* Time.deltaTime,0,0);
     }
     if(Input.GetKey("s"))
     {
       rb.AddForce(0,0,-500* Time.deltaTime);
     }
    if (Input.GetKeyDown(KeyCode.Space))
    {
     rb.AddForce (0,200,100);
     if(rb.AddForce(0,200,0)){
       rb.AddForce(0,-200,0)
     }
    }
     }
   }



