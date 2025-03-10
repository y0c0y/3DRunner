using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float _delta = -0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

        Vector3 direction = transform.position - collision.gameObject.transform.position;
        direction = direction.normalized*1000;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
    }

    // Update is called once per frame
    void Update()
    {
        var newX = transform.localPosition.x + _delta;
        transform.localPosition = new Vector3(newX,
            transform.localPosition.y,
            transform.localPosition.z);

        if (transform.localPosition.x < -3.5)
        {
            _delta = 0.1f;
        }
        else if(transform.localPosition.x > 3.5)
        {
            _delta = -0.1f;
        }
    }
}
