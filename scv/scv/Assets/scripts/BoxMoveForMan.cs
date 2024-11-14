using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BoxMoveForMan : MonoBehaviour
{

    [SerializeField] private Transform _camera;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(true);
        //transform.position = new Vector3(0, 2, 0);
        //transform.eulerAngles = new Vector3(0, 45, 30);
        //transform.localScale = new Vector3(1, 2, 4);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + new Vector3(0, 0.001f, 0);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0, 0.03f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position - new Vector3(0, 0, 0.03f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.03f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(0.03f, 0, 0);
        }
        if (Input.GetMouseButtonDown(0))
        {
            transform.localScale *= 1.2f;
        }
        if (Input.GetMouseButtonDown(1))
        {
            transform.localScale *= 0.8f;
        }
        transform.localEulerAngles = new Vector3(0, Input.mousePosition.x / 10, 0);

        _camera.position = transform.position + new Vector3(0, 2, 0);
        _camera.localEulerAngles = new Vector3(Input.mousePosition.y / 10, Input.mousePosition.x / 10, 0);
    }
}
