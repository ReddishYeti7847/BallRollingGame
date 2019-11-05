using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Script : MonoBehaviour
{
    public int floorspeed;
    public int ballspeed;

    // Start is called before the first frame update
    void Start()
    {
        //他のシーンから変数を持ってくる方法
//        titlescene = GameObject.Find("TitleGameObject");
//        Debug.Log(titlescene);  //Null…オブジェクトが見つかっていない…?🤔

        floorspeed = TitleSceneScript.GetFloorSpeed();
        ballspeed = TitleSceneScript.GetBallSpeed();
        //下の書き方はエラーになる①
        //floorspeed = titlescene.GetComponent<TitleSceneScript>().GetFloorSpeed();//GetFloorSpeed();
        //ballspeed = titlescene.GetComponent<TitleSceneScript>().ballspeed;//GetBallSpeed();
        //下の書き方はエラーになる②
        //floorspeed = TitleSceneScript.GetFloorSpeed();
        //ballspeed = TitleSceneScript.GetBallSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        //ステージを動かす
        transform.Translate(0, 0, -floorspeed * Time.deltaTime);
    
        //左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(ballspeed * Time.deltaTime, 0, 0);
        }
        //右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(-ballspeed * Time.deltaTime, 0, 0);
        }
    }
}
