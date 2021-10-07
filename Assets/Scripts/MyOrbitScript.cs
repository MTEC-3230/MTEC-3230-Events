using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyOrbitScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject objectToOrbit;
    Transform orbitTransform;
    Vector3 orbitAxis = Vector3.up;
    Vector3 orbitPostion; 
    float orbitAngle; 
        
    // Start is called before the first frame update
    void Start()
    {
        orbitTransform = objectToOrbit.transform; 
        

    }

    // Update is called once per frame
    void Update()
    {
        orbitPostion = orbitTransform.position;
        orbitAngle = Time.time * speed;
        transform.RotateAround(orbitPostion, orbitAxis, orbitAngle);
    }
}
