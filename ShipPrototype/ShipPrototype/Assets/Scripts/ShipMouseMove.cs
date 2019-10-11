using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMouseMove : MonoBehaviour
{
    public float mouseSenX = 1; //Mouse ctrl varibs
    public float mouseSenY= 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveLR = Input.GetAxis("Mouse X") * mouseSenX * Time.deltaTime;
        float moveUD = Input.GetAxis("Mouse Y") * mouseSenY * Time.deltaTime;

        Vector3 mouse = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        transform.position = new Vector3 (mouse.x, mouse.y, transform.position.z);
        
    }
}
