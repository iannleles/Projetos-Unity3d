using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftTouch : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isLeft;

    private Player player;

    public float movement;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && isLeft)
        {
            movement -= Time.deltaTime;

            if (movement < -1f)
            {
                movement = -1f;
            }
            player.movement = movement;
        }
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isLeft = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isLeft = false;
        movement = 0f;
        player.movement = movement;
    }
}
