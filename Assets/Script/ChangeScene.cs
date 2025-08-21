using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "새로하기":
                SceneManager.LoadScene("Scene1");
                break;

            case "1일차 열린 문Btn":
                SceneManager.LoadScene("Scene6(MRDialogues)");
                break;

            case "2일차 열린 문Btn":
                SceneManager.LoadScene("Scene_광철Room");
                break;

            case "스크린X확인Btn":
                SceneManager.LoadScene("Scene3");
                break;

            case "조사끝내기Btn":
                SceneManager.LoadScene("Scene12(D1EndMRDialogues)");
                break;

            case "조사끝내기":
                SceneManager.LoadScene("Scene18");
                break;

            case "Button":
                SceneManager.LoadScene("Scene19(End)");
                break;

        }
    }
}
