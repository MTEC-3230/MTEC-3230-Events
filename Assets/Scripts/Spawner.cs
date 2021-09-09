using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public int numPrefabs;
    public float radius = 10; 
    // Start is called before the first frame update
    void Start()
    {
        // Declaring variables allocates memory
        Vector3 position;
        Vector3 localRot;
        Quaternion rotation;

        for (int i = 0; i < numPrefabs; i++)
        {

             position = Random.insideUnitSphere * radius;
             localRot = Random.insideUnitSphere * 360.0f;
             rotation = Quaternion.Euler(localRot); 

            Instantiate(prefab, position, rotation);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
