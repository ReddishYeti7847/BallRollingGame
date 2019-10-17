using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle_VeryFast : MonoBehaviour
{
    private GameObject titlescene;

    // Start is called before the first frame update
    void Start()
    {
        this.titlescene = GameObject.Find("GameObject");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChange()
    {
        titlescene.gameObject.GetComponent<TitleSceneScript>().ChangeSpeed(18, 5);
    }
}
