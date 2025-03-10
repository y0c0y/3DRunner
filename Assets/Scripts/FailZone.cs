using UnityEngine;

public class FailZone : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Application.LoadLevel("Game");
        }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
