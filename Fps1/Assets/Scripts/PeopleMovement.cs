using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rg;
    float speed = 5;

    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }
    private void MoveGameObject()
    {
        var horizonalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)){
            rg.transform.Translate(Vector2.right * horizonalInput * Time.deltaTime * speed);
        }
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)){
            rg.transform.Translate(Vector2.up * verticalInput * Time.deltaTime * speed);
        }
    }
}
