using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightTouch : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isRight;

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
        if (Input.GetMouseButton(0) && isRight)
        {
            movement += Time.deltaTime;

            if (movement > 1f)
            {
                movement = 1f;
            }
            player.movement = movement;
        }
        
    }


    // é chamado quando clicamos no elemento de UI
    public void OnPointerDown(PointerEventData eventData)
    {
        isRight = true;
    }

    // é chamado quando tiramos o clique (ou touch) do elemento de UI
    public void OnPointerUp(PointerEventData eventData)
    {
        isRight = false;
        movement = 0f;
        player.movement = movement;
    }
}
