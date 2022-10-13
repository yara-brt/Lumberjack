using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BranchSpawner : MonoBehaviour
{
    public GameObject branch;
    public float spawn;
    public Transform[] spawnPoints;
    //private float nextSpawn;
    public float time;
    /*[SerializeField]
    private float minInterval;
    [SerializeField] 
    private float maxInterval;*/

    void Start()
    {
        time = 10f;
        //InvokeRepeating("Spawn", time, time);
    }

    void Spawn()
    {
        //int randomBranch = Random.Range(0, 2);
        int randomPoint = Random.Range(0, spawnPoints.Lenght);

        Instantiate(branch, spawnPoints[randomPoint].position, Quaternion.Euler(0f,0f,0f));
        time = 10f;
        //int spawnPointsIndex = Random.Range(0, spawnPoints.Length);
        //Instantiate(branch, spawnPoints[spawnPointsIndex].position, spawnPoints[spawnPointsIndex].rotation);
    }

    void Update()
    {
        time -= Time.deltaTime;
        if(time <=0)
        {
            Spawn();
        }
        float yBranch = 0;
        //float interval = Random.Range(minInterval, maxInterval);
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(branch, transform.position, branch.transform.rotation);
            yBranch = -1;
            //transform.Translate(new Vector2(0,yBranch));
        }
        if( Input.GetMouseButtonDown(1))
        {
            Instantiate(branch, transform.position, branch.transform.rotation);
            yBranch = -1;
            //transform.Translate(new Vector2(0,yBranch));
        }
        transform.Translate(new Vector2(0, yBranch));
    }   
}