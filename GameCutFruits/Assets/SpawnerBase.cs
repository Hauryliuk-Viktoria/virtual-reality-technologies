using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBase : MonoBehaviour
{

    public ObjectBase obj;
    public Transform position;
    public float TimeSpawn = 1000;

    // Start is called before the first frame update
    void Start()
    {
        //obj.Start();
        StartCoroutine(SpawnObj());
        //SpawnObj();
        
    }
    void Repeat()
    {
        StartCoroutine(SpawnObj());
        Destroy(this);
    }
    IEnumerator SpawnObj()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(obj, position.position, Quaternion.identity);
        Repeat();
        //return null;
    }

   

}
