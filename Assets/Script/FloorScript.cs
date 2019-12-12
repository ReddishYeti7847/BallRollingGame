using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    //0 … null
    //1 … 床
    //2 … ゴール

    public Material CYAM;

    int[,] stage_map =
    {
        {0, 0, 1, 0, 0 },
        {1, 1, 1, 1, 1 },
        {1, 1, 1, 1, 1 },
        {0, 1, 1, 1, 0 },
        {1, 1, 1, 1, 1 },
        {1, 1, 1, 1, 1 },
        {0, 1, 0, 1, 0 },
        {0, 1, 0, 1, 0 },
        {0, 1, 0, 1, 0 },
        {0, 1, 1, 1, 0 },
        {0, 0, 1, 0, 0 },
        {0, 0, 1, 1, 0 },
        {0, 0, 0, 1, 0 },
        {0, 0, 1, 1, 0 },
        {0, 0, 1, 0, 0 }
    };

    // Start is called before the first frame update
    void Start()
    {
        CreateStage();

        //他のシーンから変数を持ってくる方法
        //        titlescene = GameObject.Find("TitleGameObject");
        //        Debug.Log(titlescene);  //Null…オブジェクトが見つかっていない…?🤔

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

    }

    //ステージ生成
    void CreateStage()
    {
        var parent = this.transform;

        // 床の全削除
        var clones = GameObject.FindGameObjectsWithTag("Floor");
        foreach (var clone in clones)
        {
            Destroy(clone);
        }

        //配置
        for (int i = 0; i < stage_map.GetLength(0); i++)
        {
            for (int j = 0; j < stage_map.GetLength(1); j++)
            {
                int item = stage_map[i, j];
                if (item != 0)
                {
                    var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.tag = "Floor";
                    cube.GetComponent<Renderer>().material.color = Color.cyan;
                    cube.transform.position = new Vector3((j - 2) * 5, 0, i * 5);
                    cube.transform.localScale = new Vector3(5, 0.5f, 5);

                    if (item == 2)
                    {
                        cube.AddComponent<>();
                    }
                }
            }
        }
    }
}
