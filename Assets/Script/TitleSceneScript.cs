using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// TODO:
//      ①Speedクラスを消す(速度は普通の変数で)
//      ②プレハブを作る(ステージの床など)
//      ③ボールとカメラを動かすようにする？
//      ④2次元配列を使用して床を配置する

public class TitleSceneScript : MonoBehaviour
{
    private static bool start = true;
    public static int floorspeed = 4;
    public static int ballspeed = 5;

    public int  testc = 1;
    //public GameObject titlescene;

    // Start is called before the first frame update
    void Start()
    {
        //titlescene = GameObject.Find("TitleGameObject");
        //floorspeed;
        //ballspeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSpeed(int initfloorspeed, int initballspeed)
    {
        floorspeed = initfloorspeed;
        ballspeed = initballspeed;

        Debug.Log(floorspeed);
        Debug.Log(ballspeed);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Main");
    }

    public static int GetFloorSpeed()
    {
        return floorspeed;
    }

    public static int GetBallSpeed()
    {
        return ballspeed;
    }

    public void Test()
    {
        Debug.Log(121312);
    }
}