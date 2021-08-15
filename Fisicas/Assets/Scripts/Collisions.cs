using UnityEngine;

public class Collisions : MonoBehaviour
{
    private Rigidbody rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Chamado a cada frame enquanto pressionar o botao W no teclado
        if (Input.GetKey(KeyCode.W))
        {
            rig.velocity = new Vector3(1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rig.velocity = new Vector3(-1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rig.velocity = new Vector3(0f, 0f, -1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rig.velocity = new Vector3(0f, 0f, 1f);
        }
    }
    // Detecta Colisao no primeiro toque do objeto
    // private void OnCollisionEnter(Collision collision)
    // {
    //     Debug.Log("Enter");
    // }

    // //é chamado ao parar de colidir com um outro objeto
    // private void OnCollisionExit(Collision collision)
    // {
    //     Debug.Log("Exit");
    // }

    // //é chamado enquanto o objeto colide com outro obj
    // private void OnCollisionStay(Collision collision)
    // {
    //     Debug.Log("Stay!");
    // }
}
