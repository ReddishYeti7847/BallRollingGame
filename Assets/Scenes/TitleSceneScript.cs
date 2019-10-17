using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneScript : MonoBehaviour
{
    static bool start = true;
    static Speed speed = new Speed(4, 5);

    // Start is called before the first frame update
    void Start()
    {
        speed.ChangeSpeed(4, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSpeed(int FloorSpeed, int BallSpeed)
    {
        speed.ChangeSpeed(FloorSpeed, BallSpeed);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Main");
    }

    public static Speed GetSpeed()
    {
        return speed;
    }
}

public class Speed
{
    int FloorSpeed; //現在のスピード
    int BallSpeed;  //現在のスピード

    public Speed(int FloorSpeed, int BallSpeed)
    {
        this.FloorSpeed = FloorSpeed;
        this.BallSpeed = BallSpeed;
    }

    public void ChangeSpeed(int FloorSpeed, int BallSpeed)
    {
        this.FloorSpeed = FloorSpeed;
        this.BallSpeed = BallSpeed;
    }

    public int GetFloorSpeed()
    {
        return FloorSpeed;
    }

    public int GetBallSpeed()
    {
        return FloorSpeed;
    }
}
