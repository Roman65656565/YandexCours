using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _oldMousePositionx;
    private float _eulerY;
    [SerializeField] Animator _animator;



    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            _oldMousePositionx = Input.mousePosition.x;
            _animator.SetBool("Run", true);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * _speed;

            newPosition.x = Mathf.Clamp(newPosition.x, -3.5f, 3.5f);
            transform.position = newPosition;

            float deltax = Input.mousePosition.x - _oldMousePositionx;
            _oldMousePositionx = Input.mousePosition.x;

            _eulerY += deltax;
            _eulerY = Mathf.Clamp(_eulerY, -70, 70);
            transform.eulerAngles = new Vector3(0, _eulerY, 0);
        }
        if (Input.GetMouseButtonUp(0)) 
        {
            _animator.SetBool("Run", false);
        }
    }
}
