using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball_Jump : MonoBehaviour
{
    public GameObject Ball;
    //private Rigidbody BallRigid;//PlayerオブジェクトのRigidbobyを保管する
    //public float JumpSpeed;
    private Vector3 point;


    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.Find("Sphere");
        //BallRigid = Ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        point = Ball.transform.position;

        if (point.y < -10)
        {
            GameOver();
        }

        /* if (Input.GetKeyDown(KeyCode.Return))
        {
            //上にジャンプする。
            BallRigid.AddForce(transform.up * JumpSpeed);
        } */
    }

    //ボールが一定以上下に落ちたらゲームオーバーにする
    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
