using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButonScript : MonoBehaviour
{
    public void StartLevel(string LevelName){

        SceneManager.LoadScene(LevelName);
    }

    public void PlayerButton(string LevelChooseScene){

        SceneManager.LoadScene(LevelChooseScene);
    }

}
