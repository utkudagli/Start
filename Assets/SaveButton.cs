using Proyecto26;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveButton : MonoBehaviour
{
    private Button save;
    private Text username;
    private GameObject parent;
    public static string user;
    public ButtonClick button;
    // Start is called before the first frame update
    void Start()
    {
        save = GetComponent<Button>();
        username = transform.parent.gameObject.transform.GetChild(0).Find("Text").GetComponent<Text>();
        parent = transform.parent.gameObject;
        save.onClick.AddListener(SaveUsername);
    }

    public void SaveUsername(){
        user = username.text;
        PostToDatabase();
        parent.SetActive(false);
        button.Reset();
    }
    private void PostToDatabase()
    {
        User user = new User();
        //PlayfabManager.SendLeaderboard(button.timeFormat);
    }

    
}
