using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;

public class PlayerMoveMe : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _OldMousePositionx;
    private float _OldMousePositiony;
    [SerializeField] private Transform _camera;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + transform.forward * Time.deltaTime * _speed;
        }

        if (Input.GetMouseButtonDown(0))
        {
            _OldMousePositionx = Input.mousePosition.x;
            _OldMousePositiony = Input.mousePosition.y;
        }

        if (Input.GetMouseButton(0))
        {
            float deltax = Input.mousePosition.x - _OldMousePositionx;
            _OldMousePositionx = Input.mousePosition.x;

            float deltay = Input.mousePosition.y - _OldMousePositiony;
            _OldMousePositiony = Input.mousePosition.y;

            transform.eulerAngles += new Vector3(0, deltax, 0);

            _camera.position = transform.position + new Vector3(0, 1, 0);
            _camera.eulerAngles += new Vector3(-deltay, deltax, 0);

        }


    }
    
    


}
