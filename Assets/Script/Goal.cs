using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private GameObject floor;

    // Start is called before the first frame update
    void Start()
    {
        this.floor = GameObject.Find("Floor");  //Floorオブジェクトを認識する
    }

    // Update is called once per frame
    void Update()
    {

    }

    // ボールがゴールに接触したときの処理
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("触れた");

        if (collision.gameObject.tag == "Sphere")
        {
            //シーンを切り替える
            SceneManager.LoadScene("Goal");
        }
    }

}
