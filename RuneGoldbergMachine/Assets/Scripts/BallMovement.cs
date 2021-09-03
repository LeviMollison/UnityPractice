using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
	private float m_Speed = 10.0f;
	private float m_RotationSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
     	
    }

    // Update is called once per frame
    void Update()
    {
    	float translation = Input.GetAxis("Vertical") * m_Speed;
    	float rotation = Input.GetAxis("Horizontal") * m_RotationSpeed;

    	translation *= Time.deltaTime;
    	rotation *= Time.deltaTime;
        
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}
