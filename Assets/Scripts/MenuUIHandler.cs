using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public TextMeshProUGUI highScore;
    public TMP_InputField inputField;

    public void Awake()
    {
        highScore.text = "High Score: " + DataManager.Instance.highScore +" - "+ DataManager.Instance.userNameHighScore;
    }

    public void SetName()
    {
        userName.text = inputField.text;
        DataManager.Instance.userName = userName.text;
    }

    

    public void StartNew()
    { if(inputField.text != string.Empty)
        {
            SceneManager.LoadScene(1);
        }
        
    }

    public void ExitGame()
    {
     
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif

    }
}
