using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody PlayerRigid = default;
    public float speed = default;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRigid = GetComponent<Rigidbody>();

        //PlayerRigid = null;

        //Debug.Assert(PlayerRigid != null);

        //if(PlayerRigid == null)
        //{
        //    Debug.LogError("Player의 RigidBody 컴포넌트를 찾을 수 없습니다");
        //}
        //GFunc.Log("이거 그대로 잘 찍힌다.");
    }

    // Update is called once per frame
    void Update()
    {


        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3 (xSpeed, 0f , zSpeed);
        PlayerRigid.velocity = newVelocity;


    }

    public void Die()
    {
        gameObject.SetActive(false);


        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.Endgame();
    }

}
