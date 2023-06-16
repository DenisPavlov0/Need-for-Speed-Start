
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var position = transform.position;
        var stepForward = _speed * Time.deltaTime;
        var stepSide = stepForward / 2;

        if (Input.GetKey(KeyCode.W))
        {
            position.x += stepForward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            position.x -= stepForward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            position.z -= stepForward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            position.z += stepForward;
        }
       

        transform.position = position;

    }
}
