using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _targetPoint;

    private void Update()
    {
        transform.position = new Vector3(47f,1.5f , Mathf.Sin(Time.time * _speed) * 10f);
    }

}
