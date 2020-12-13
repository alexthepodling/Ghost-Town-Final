using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBoundaries : MonoBehaviour
{
    public float speed; 

    private Vector3 directionVector;
    private Transform myTransform;
    private Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeDirection()
    {
        int direction = Random.Range(0, 4);
        switch(direction)
        {
            case 0:
                //Walking right
                directionVector = Vector3.right;
                break;
            case 1:
                //Walking up
                directionVector = Vector3.up;
                break;
            case 2:
                //Walking left
                directionVector = Vector3.left;
                break;
            case 3:
                //walking down
                directionVector = Vector3.down;
                break;
            default:
                break;
        }
    }

    private void Move()
    {
        myRigidbody.MovePosition(myTransform.position + directionVector * speed * Time.deltaTime);
    }
}
