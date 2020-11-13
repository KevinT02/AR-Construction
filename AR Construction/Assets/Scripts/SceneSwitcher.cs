using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void TutorialVideo1()
    {
        SceneManager.LoadScene(1);
    }
    public void TutorialSelect()
    {
        SceneManager.LoadScene(0);
    }
    public void OnSiteOffSite()
    {
        SceneManager.LoadScene(2);
    }
    public void OnSiteWarning()
    {
        SceneManager.LoadScene(3);
    }
    public void OffSiteWarning()
    {
        SceneManager.LoadScene(4);
    }
    public void FrenchTutoralSelect()
    {
        SceneManager.LoadScene(6);
    }
}