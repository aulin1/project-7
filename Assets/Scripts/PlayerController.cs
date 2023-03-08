using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public Transform sword;

    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(sword);
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if(moveVertical != 0 || moveHorizontal != 0){
            Vector3 moveTo = sword.position;
            moveTo.y = 0;
            controller.Move(moveTo * Time.deltaTime * speed);
        }
    }
}
