using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject platform;
    public Camera camera;

    public int nrPlatforms;
    public float cameraWidth = 15f;
    public float minDistance = 0.5f;
    public float maxDistance = 2.5f;


    // Start is called before the first frame update
    void Start()
    {
        float spawnHeight = 0f;
        for (int i = 0; i < nrPlatforms; i++)
        {
            spawnHeight += Random.Range(minDistance, maxDistance);
            float xPosition = Random.Range(-cameraWidth / 2, cameraWidth / 2);
            Instantiate(platform, new Vector3(xPosition, spawnHeight, 0), Quaternion.AngleAxis(90, Vector3.forward));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
