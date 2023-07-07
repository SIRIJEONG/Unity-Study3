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
        //    Debug.LogError("Player�� RigidBody ������Ʈ�� ã�� �� �����ϴ�");
        //}
        //GFunc.Log("�̰� �״�� �� ������.");
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
