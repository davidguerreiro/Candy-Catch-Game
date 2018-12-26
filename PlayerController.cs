using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool canMove = true;
    [SerializeField]
    float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( canMove ) {
            Move();
        }
    }

    private void Move() {
        float inputX = Input.GetAxis( "Horizontal" );
        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;
    }
}
