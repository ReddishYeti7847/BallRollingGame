using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;

public class SubmitButton : MonoBehaviour
{
    public GameObject titlescene;

    //連携するGameObject
    public ToggleGroup toggle_group;
    public void Start() => titlescene = GameObject.Find("TitleGameObject");

    public void onClick()
    {
        //checkのついた値を返す
        string selectedLabel = toggle_group.ActiveToggles().First().GetComponentsInChildren<Text>().First(t => t.name == "Label").text;

        switch (selectedLabel)
        {
            case "遅い":
                Debug.Log("遅い");
                titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(2, 4);
                break;
            case "普通":
                Debug.Log("普通");
                titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(4, 5);
                break;
            case "速い":
                Debug.Log("速い");
                titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(8, 5);
                break;
            case "すごく速い":
                Debug.Log("すごく速い");
                titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(18, 5);
                break;
            default:
                Debug.Log("エラー");
                break;
        }

        titlescene.GetComponent<TitleSceneScript>().ChangeScene();

        //Debug.Log("selected " + selectedLabel);

    }
}
