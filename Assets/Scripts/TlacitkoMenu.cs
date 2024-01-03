using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TlacitkoMenu : MonoBehaviour
{

    public class SceneSwitcherOnClick : MonoBehaviour
{
    public string sceneToLoad = "Game";

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
}
