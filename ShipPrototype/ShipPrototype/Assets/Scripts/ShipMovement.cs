 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float verticalInput;
    public float horizontalInput;
    public GameObject LowPolyMissile;
    public GameObject LowPolyShip;
    public GameObject spawnPosObj;
    // Start is called before the first frame update
   void FixedUpdate()
   {
       //Vertical Input
       verticalInput = Input.GetAxis("Vertical");
       //HorizontalInput
       horizontalInput = Input.GetAxis("Horizontal");

       //Move plane forward at constant speed
       transform.Translate(-Vector3.left*Time.deltaTime*speed);

       //Tile Plane up and down
       transform.Rotate(Vector3.forward, turnSpeed * verticalInput * Time.deltaTime);
       //Tilts left and right
       transform.Rotate(Vector3.right * Time.deltaTime * speed * horizontalInput);

       //Space bar for projectiles
       if (Input.GetKeyDown(KeyCode.Space)){
           //this implies object variable
           GameObject LowPolyMissile = (GameObject) Instantiate(this.LowPolyMissile, spawnPosObj.transform.position, transform.rotation);

            LowPolyMissile.GetComponent<ProjectileMove>().travelDirection = transform.right; //<Make this go backwards
       }

       
   }
}
