using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShoot : MonoBehaviour
{
    //gunDamage determins how much damage is applied to obj when shot
    public int gunDamage = 1;
    //firerate controls how often they can fire. Set to .25 seconds
    public float fireRate = .25f;
    //range is how far into scene
    public float weaponRange = 50f;
    //if raycast hits object with rigit body this will apply force.
    public float hitForce = 100f;
    //Marks posistion of where raycast will begin.
    public Transform gunEnd;

    private Camera ShotCam;
    private WaitForSeconds shotDuration = new WaitForSeconds(.07f);
    //Draws straight line between two points
    private LineRenderer laserLine;
//nextfire holds time before allowed to fire.
    private float nextFire; 

    // Start is called before the first frame update
    void Start()
    {
        laserLine = GetComponent<LineRenderer>();
        //could put gun audio under this?

        ShotCam = GetComponentInParent<Camera>();
    }

    // Update is called once per frame
    void Update()
   
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire){
        nextFire = Time.time + fireRate;

        Vector3 rayOrgin = ShotCam.ViewportToWorldPoint (new Vector3(.5f, .5f, 0));

        RaycastHit hit;

        laserLine.SetPosition(0, gunEnd.position);
        if (Physics.Raycast (rayOrgin, ShotCam.transform.forward, out hit,weaponRange)) {laserLine.SetPosition(1, hit.point);}
        else
        {
            laserLine.SetPosition(1, rayOrgin + (ShotCam.transform.forward * weaponRange));
        }
        
        }
    }
}
