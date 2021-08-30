using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTouch : MonoBehaviour
{
    private Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    public void Fire()
    {
        player.touchFire = true;
    }
}
