using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour
{
    public void TaskOnClick(string name)
    {
        SceneManager.LoadScene(name);
    }
}
