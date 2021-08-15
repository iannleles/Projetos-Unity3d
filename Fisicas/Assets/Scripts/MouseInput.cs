using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetMouseButton também é reconhecido pelo touch do celular
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;

            transform.position = Camera.main.ScreenToWorldPoint(mousePos);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Down");
    }

    private void OnMouseDrag()
    {
        Debug.Log("Drag");
    }

    private void OnMouseUp()
    {
        Debug.Log("Up");
    }

    private void OnMouseExit()
    {
        Debug.Log("Exit");
    }
}
