using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public int floorspeed;
    public int ballspeed;

    //private Rigidbody BallRigid;//PlayerオブジェクトのRigidbobyを保管する
    //public float JumpSpeed;
    private Vector3 point;

    // Start is called before the first frame update
    void Start()
    {
        floorspeed = TitleSceneScript.GetFloorSpeed();
        ballspeed = TitleSceneScript.GetBallSpeed();
        Debug.Log("floorspeed" + floorspeed);
        Debug.Log("ballspeed" + ballspeed);

        //BallRigid = Ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        point = this.transform.position;

        if (point.y < -10)
        {
            GameOver();
        }

        //ボールを前に動かす
        transform.Translate(0, 0, floorspeed * Time.deltaTime);

        //左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-ballspeed * Time.deltaTime, 0, 0);
        }
        //右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(ballspeed * Time.deltaTime, 0, 0);
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
