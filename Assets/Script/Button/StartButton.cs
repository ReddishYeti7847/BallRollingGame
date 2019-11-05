using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject titlescene;

    // Start is called before the first frame update
    void Start()
    {
        titlescene = GameObject.Find("TitleGameObject");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClick()
    {
        titlescene.GetComponent<TitleSceneScript>().ChangeScene();
    }
}
