using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    // check if the candy is touching the player.
    void OnTriggerEnter2D( Collider2D collider )
    {
        if ( collider.gameObject.tag == "Player" ) {
            // displays the score - Check GameManager Class.
            GameManager.instance.IncrementScore();
            Destroy( gameObject );
        } else if ( collider.gameObject.tag == "Boundary" ) {
            // decrease lives.
            Destroy( gameObject );
        }


    }
}
