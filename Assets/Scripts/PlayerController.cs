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
        //transform.LookAt(sword);
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        if(Mathf.Abs(moveVertical + moveHorizontal) > 0){
            controller.SimpleMove(Time.deltaTime * speed * -Vector3.right);
        }
    }
}
