using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed=45.0f;
    [SerializeField] float turnspeed = 20.0f;
    private float horizontalInput;
    private float forwordInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwordInput = Input.GetAxis("Vertical");

        
        transform.Translate(Vector3.forward*speed*Time.deltaTime*forwordInput);
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime); 

    }
}
