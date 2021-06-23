using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public void load(string melyik)
    {
         SceneManager.LoadScene(melyik);
    }
}
