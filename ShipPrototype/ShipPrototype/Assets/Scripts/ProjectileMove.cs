using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public float speed = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves projectile forward
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
