using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabRandomizer : MonoBehaviour
{

    void Start()
    {
        Vector3 randomScale = new Vector3(Random.Range(1.0f, 2.0f),//x
            Random.Range(1.0f, 2.0f),//y
            Random.Range(1.0f, 2.0f));//z

        transform.localScale = randomScale;
    }


}
