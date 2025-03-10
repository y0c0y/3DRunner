using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float startingPoint;
    SphereCollider sphereCollider;
    
    void Start()
    {
        startingPoint = transform.position.z;
        
        sphereCollider = GetComponent<SphereCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = transform.position.z - startingPoint;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
        }
        
    }
}
