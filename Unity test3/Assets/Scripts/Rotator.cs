using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public BulletSpawner spawner;

    public float rorationSpeed = 60f;
    // Start is called before the first frame update
    void Start()
    {
        spawner = transform.Find("Nose").GetComponent<BulletSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!spawner.isCheck)
            transform.Rotate(0f, rorationSpeed * Time.deltaTime, 0f);;
    }
}
