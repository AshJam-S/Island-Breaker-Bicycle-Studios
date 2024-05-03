using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float xRange;
    [SerializeField] private float zMin;
    [SerializeField] private float zMax;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");

        Vector3 move = Vector3.right * hInput + Vector3.forward * vInput;
        move = move.normalized * speed;
        transform.Translate(move * Time.deltaTime);
    }
}
