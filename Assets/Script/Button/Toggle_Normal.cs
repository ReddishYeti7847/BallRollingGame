using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle_Normal : MonoBehaviour
{
    public GameObject titlescene;

    // Start is called before the first frame update
    void Start()
    {
        this.titlescene = GameObject.Find("TitleGameObject");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChange(bool ischecked)
    {
        //titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(4, 5);
        Debug.Log("普通");
    }
}
