using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool canMove = true;
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float maxPos;
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
        // get horzontal axis and then re-assiging to position x by multiplying x position per speed per Time.deltaTime to adjust frame, the assign to the X value in a Vector3.
        float inputX = Input.GetAxis( "Horizontal" );
        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;

        // avoid player going out of screen, by using Clamp you get min and max value of screen, then reassign to Player transform position Vector3.
        float xPos = Mathf.Clamp( transform.position.x, -maxPos, maxPos );
        transform.position = new Vector3( xPos, transform.position.y, transform.position.z );
    }

}
