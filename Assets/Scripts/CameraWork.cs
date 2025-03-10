using UnityEngine;

public class CameraWork : MonoBehaviour
{
    GameObject player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0,
            player.transform.position.y + 3,
            player.transform.position.z - 14);
    }
}
