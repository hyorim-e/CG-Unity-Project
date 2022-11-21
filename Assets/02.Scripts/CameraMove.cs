using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{
    private Transform _transform;
    private float _horizontal = .0f;
    private float _vertical = .0f;

    public float moveSpd = 5.0f;
    public float rotateSpd = 100.0f;

    public Toggle isCameraRotate;

    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        Vector3 moveDirect = (Vector3.forward * _vertical) + (Vector3.right * _horizontal);
        _transform.Translate(moveDirect.normalized * Time.deltaTime * moveSpd, Space.Self);

        if (isCameraRotate.isOn)
        {
            _transform.Rotate(Vector3.up * Time.deltaTime * rotateSpd * Input.GetAxis("Mouse X"));
        }
        
    }
}
