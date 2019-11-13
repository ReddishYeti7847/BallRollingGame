using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class StartButton : MonoBehaviour
{
    public GameObject titlescene;
    public ToggleGroup toggleGroup;

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
        string selectedLabel = toggleGroup.ActiveToggles()
            .First().GetComponentsInChildren<Text>()
            .First(t => t.name == "Label").text;

        Debug.Log("selected " + selectedLabel);

        titlescene.GetComponent<TitleSceneScript>().ChangeScene();
    }
}
