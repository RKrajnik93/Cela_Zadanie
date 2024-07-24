using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public GameObject Cube, Capsule, Sphere;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Cube, new Vector3(-3, 1, 0), Quaternion.identity);   
        Instantiate(Capsule, new Vector3(0, 1, 0), Quaternion.identity);   
        Instantiate(Sphere, new Vector3(3, 1, 0), Quaternion.identity);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
