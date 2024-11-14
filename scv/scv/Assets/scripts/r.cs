using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform _camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, 0.03f, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 0.03f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, 0.03f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.03f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(0.03f, 0, 0);
        }
        _camera.localEulerAngles = new Vector3(Input.mousePosition.y / 10, Input.mousePosition.x / 10, 0);

        transform.localEulerAngles = new Vector3(0, Input.mousePosition.x / 10, 0);



        _camera.position = transform.position + new Vector3(0, 2, 0);
    }
}
