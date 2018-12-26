using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{

    [SerializeField]
    float maxX;
    public GameObject [] Candies;
    [SerializeField]
    float spawnInterval;
    // Start is called before the first frame update


    // make this class static.
    public static CandySpawner instance;

    private void Awake() {
        if ( instance ==  null ) {
            instance = this;
        }
    }

    void Start()
    {
        StartSpawningCandies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandy() {
        int rand            = Random.Range( 0, Candies.Length );
        float randomX       = Random.Range( - maxX, maxX );
        Vector3 randomPos   = new Vector3( randomX, transform.position.y, transform.position.z );

        Instantiate( Candies[ rand ], randomPos, transform.rotation );
    }

    // SetTimeOut();
    IEnumerator SpawnCandies() {
        yield return new WaitForSeconds( 2f );

        while ( true ) {
            SpawnCandy();
            yield return new WaitForSeconds( spawnInterval );
        }
    }

    public void StartSpawningCandies() {
        StartCoroutine( "SpawnCandies" );
    }

    public void StopSpawningCandies() {
        StopCoroutine( "SpawnCandies" );
    }
}
