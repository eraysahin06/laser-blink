using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject Engeller;
    public GameObject Bird;
    public Transform targetX;
    public float targetY;

    void Start()
    {
        SpawnBird();
        StartCoroutine(SpawnEngel());
    }

    void Update()
    {

    }

    IEnumerator SpawnEngel()
    {
        yield return new WaitForSeconds(Random.Range(1, 3));
        Instantiate(Engeller, new Vector3(targetX.position.x, Random.Range(-targetY, targetY), 0), Quaternion.identity);
        StartCoroutine(SpawnEngel());
    }

    void SpawnBird()
    {
        Vector3 spawnPosition = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 10));

        Instantiate(Bird, spawnPosition, Quaternion.identity);

    }
}
