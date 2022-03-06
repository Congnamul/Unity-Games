using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerR;
    public float speed = 9f;

    float hAxis;
    float vAxis;
    Vector3 moveVec;


    // Start is called before the first frame update
    void Start()
    {
        playerR = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        transform.position += moveVec * speed * Time.deltaTime;
    }

    public void Die()
    {
        gameObject.SetActive(false);

        Gamemanager gameManager = FindObjectOfType<Gamemanager>();

        gameManager.EndGame();
    }
}
