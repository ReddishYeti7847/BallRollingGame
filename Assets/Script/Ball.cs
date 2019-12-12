using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    //スピード
    public int ballspeed_x; //横方向のボールの速度
    public int ballspeed_z; //縦方向のボールの速度
    //位置
    public Vector3 pos;
    //ジャンプ
    public bool foot;   //床に触れているかどうか

    public Rigidbody rigidbody;
    public int jumpcount;       //ジャンプ回数
    public Vector3 jumpspeed;
    //カメラオブジェクト
    public GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        ballspeed_z = TitleSceneScript.GetFloorSpeed();
        ballspeed_x = TitleSceneScript.GetBallSpeed();
        Debug.Log("floorspeed" + ballspeed_z);
        Debug.Log("ballspeed" + ballspeed_x);

        rigidbody = this.GetComponent<Rigidbody>();
        jumpspeed = new Vector3(0f, 200f, 0f);

        mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールを前に動かす
        transform.Translate(0, 0, ballspeed_z * Time.deltaTime);

        //左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-ballspeed_x * Time.deltaTime, 0, 0);
        }
        //右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(ballspeed_x * Time.deltaTime, 0, 0);
        }
        //上にジャンプする。
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpcount < 2)
            {
                jumpcount++;                    //ジャンプ回数を増やす
                rigidbody.AddForce(jumpspeed);  //上方向の速度を加える
            }
        }

        pos = this.transform.position;

        //落下判定
        if (pos.y < -10)
        {
            GameOver();
        }

        //カメラを追従させる
        mainCamera.transform.position = new Vector3(pos.x, pos.y + 3, pos.z - 5);
    }

    //着地判定
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("触れた");

        if (collision.gameObject.tag == "Floor")
        {
            //シーンを切り替える
            jumpcount = 0;
        }
    }

    //ボールが一定以上下に落ちたらゲームオーバーにする
    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
