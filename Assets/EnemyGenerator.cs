using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy_0Prefab;
    float span = 0.7f;
    float delta = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Enemy_0Prefab);
            int px = Random.Range(-6, 6);
            go.transform.position = new Vector3(10, px, 0);
        }
    }
}
