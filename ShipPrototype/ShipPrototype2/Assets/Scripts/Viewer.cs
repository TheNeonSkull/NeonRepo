using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewer : MonoBehaviour
{
    public float weaponRange = 50f;
    private Camera ShotCam;
    // Start is called before the first frame update
    void Start()
    {
        ShotCam = GetComponentInParent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lineOrigin = 
        ShotCam.ViewportToWorldPoint(new Vector3(0.5f,0.5f,0.0f));
        Debug.DrawRay(lineOrigin,ShotCam.transform.forward* weaponRange,Color.black);
    }
}
