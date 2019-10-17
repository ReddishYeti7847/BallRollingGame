using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Script : MonoBehaviour
{
    public Speed speed;
    private GameObject titlescene;

    // Start is called before the first frame update
    void Start()
    {
        speed = TitleSceneScript.GetSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        //ステージを動かす
        transform.Translate(0, 0, -speed.GetFloorSpeed() * Time.deltaTime);
    
        //左に移動
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(speed.GetBallSpeed() * Time.deltaTime, 0, 0);
        }
        //右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(-speed.GetBallSpeed() * Time.deltaTime, 0, 0);
        }
    }
}
