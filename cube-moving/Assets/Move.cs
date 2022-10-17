using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed = 5;
    public int jumpHeight = 4;
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0, moveZ);
        transform.Translate(movement * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumping = new Vector3(moveX, jumpHeight, moveZ);
            transform.Translate(jumping * speed * Time.deltaTime);

        }

    }
}
