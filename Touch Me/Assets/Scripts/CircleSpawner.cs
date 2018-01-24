using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleSpawner : MonoBehaviour {

    public GameObject circlePrefab;
    public Transform holder;
    public RectTransform corner;
    public Color[] circleColors;

    public float minSpawnTime;
    public float maxSpawnTime;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(SpawnCircle());
	}
	
	IEnumerator SpawnCircle()
    {
        while (true)
        {
            float spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(spawnTime);
            GameObject spawnedCircle = Instantiate(circlePrefab, holder) as GameObject;
            spawnedCircle.GetComponent<RectTransform>().position = FindCirclePosition();
            spawnedCircle.GetComponent<Image>().color = circleColors[Random.Range(0, circleColors.Length)];
        }
    }

    Vector3 FindCirclePosition()
    {
        float x = Random.Range(0, corner.position.x);
        float y = Random.Range(0, corner.position.y);
        Debug.Log(x + " " + y);
        return new Vector3(x, y, 0);
    }
}
