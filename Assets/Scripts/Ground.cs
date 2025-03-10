using Unity.VisualScripting;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float zRotation = transform.localEulerAngles.z;
        zRotation -= Input.GetAxis("Horizontal");
        transform.localEulerAngles = new Vector3(10, 0, zRotation);

        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            Debug.Log(Input.touchCount);

            if (Input.mousePosition.x < Screen.width / 2.0f)
            {
                transform.localEulerAngles = new Vector3(
                    transform.localEulerAngles.x,
                    transform.localEulerAngles.y,
                    zRotation + 0.5f);
            }
            else
            {
                transform.localEulerAngles = new Vector3(
                    transform.localEulerAngles.x,
                    transform.localEulerAngles.y,
                    zRotation - 0.5f);
            }
        }

    }
}
