using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{



    public GameObject bulletPrefab = default;
    public float spawnerRateMin = 0.5f;
    public float spawnerRateMax = 3.0f;

    private Transform target = default;
    private float spawnerRate = default;
    private float timeAfterSpawner = default;

    public bool isCheck = false;
    public GameObject body;

    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawner = 0f;
        spawnerRate = Random.Range(spawnerRateMin, spawnerRateMax); 
        target = FindAnyObjectByType<PlayerControl>().transform;

    }

    // Update is called once per frame
    void Update()
    {
        float pos = Vector3.Distance(transform.position, target.position);



        timeAfterSpawner += Time.deltaTime;

        if (pos < 10f)
        {
            isCheck = true;
        }
        else
        {
            isCheck = false;
        }

        if(isCheck)
        {
            
            if (timeAfterSpawner >= spawnerRate)
            {
                timeAfterSpawner = 0f;

            body.transform.LookAt(target);
                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                //bullet.transform.LookAt(target);

                spawnerRate = Random.Range(spawnerRateMin, spawnerRateMax);
            }
        }
    }


}
