using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private float _coolDown = 0.5f;
    private float _lastShootAt = 0;


    private void Start()
    {
        SpawnElements();
    }
    private void SpawnElements()
    {
        GameObject instance = Instantiate(_template, transform.position + new Vector3(-2f, 2f, 0), Quaternion.identity);
        instance.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 1, 0) * 900f);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time - _lastShootAt >= _coolDown)
        {
            SpawnElements();
            _lastShootAt = Time.time;
        }
    }
    
}
