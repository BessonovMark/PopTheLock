using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField]
    private GameObject _anchor;

    [SerializeField]
    private float _speed;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(_anchor.transform.position, transform.forward, _speed * Time.deltaTime);
    }
}
