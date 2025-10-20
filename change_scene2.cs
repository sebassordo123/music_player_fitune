using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class change_scene2 : MonoBehaviour
{

    public void changemenuscene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
