using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle_Low : MonoBehaviour
{
    public GameObject titlescene;

    // Start is called before the first frame update
    void Start()
    {
        titlescene = GameObject.Find("TitleGameObject");
        Debug.Log(titlescene.GetComponent<TitleSceneScript>().testc);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnValueChange(bool ischecked)
    {
        Debug.Log("遅い");
    }

    /*

    public void OnValueChange(bool ischecked)
    {
        Debug.Log(123);

        Debug.Log(titlescene.GetComponent<TitleSceneScript>().testc);
        
        titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(2, 4);
    }
    */
}
