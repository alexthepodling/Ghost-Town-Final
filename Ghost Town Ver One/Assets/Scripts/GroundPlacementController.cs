using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GroundPlacementController : MonoBehaviour
{
    [SerializeField] private GameObject furniturePrefab;
   // [SerializeField] private KeyCode newObjectHotKey = KeyCode.M;

    private GameObject currentPlaceableObject;
    private float mouseWheelRotation;

    private void Update()
    {
        HandleNewObjectHotKey();

        if(currentPlaceableObject != null)
        {
            MoveCurrentPlaceableObjectToPoint();
        }

        RotateTheObject();

        ReleaseTheObject();
    }

    private void HandleNewObjectHotKey()
    {
        //if (Input.GetKeyDown(newObjectHotKey))
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            currentPlaceableObject = Instantiate(furniturePrefab);
        }

        else
        {
            Destroy(currentPlaceableObject);
        }
    }

    private void MoveCurrentPlaceableObjectToPoint()
    {
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       //THIS Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position);

        //Vector2 mousePos2D = Mouse.current.position;
        //Ray ray = Camera.main.ScreenPointToRay(new Vector3(mousePos2D.x, mousePos2D.y, Camera.main.transform.position.z));

        //Vector2 mousePos2D = Camera.main.ScreenPointToRay(Mouse.current.position);
        //Ray ray = new Ray(new Vector3(mousePos2D.x, mousePos2D.y, Camera.main.transform.position.z), Camera.main.transform.forward);

       // RaycastHit hitInfo;
      //  if(Physics.Raycast(ray, out hitInfo))
      //  {
      //      currentPlaceableObject.transform.position = hitInfo.point;
      //      currentPlaceableObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
      //  }

    }

    private void RotateTheObject()
    {
        mouseWheelRotation = Input.mouseScrollDelta.y;
        currentPlaceableObject.transform.Rotate(Vector3.up, mouseWheelRotation * 10);
    }

    private void ReleaseTheObject()
    {
        if(Mouse.current.leftButton.isPressed)
        {
            currentPlaceableObject = null;
        }
    }
}
