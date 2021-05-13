using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform SpawnPoint;
    public GameObject Prefab;
    public int fieldRadius = 1000;
    public int astroidCount = 2000;

    void Start()
    {
        for (int loop = 0; loop < astroidCount; loop++)
        {
            Transform temp = Instantiate(SpawnPoint, Random.insideUnitSphere * fieldRadius, Random.rotation);
            temp.localScale = temp.localScale * Random.Range(0.5f, 5);

        }
    }
}
