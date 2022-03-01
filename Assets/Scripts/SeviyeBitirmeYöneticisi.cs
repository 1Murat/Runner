using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SeviyeBitirmeYöneticisi : MonoBehaviour
{
    public void Seviye1Bitir(){

        SeviyeYonetici.level2 = true;
        SceneManager.LoadScene(1);
    }
    
    public void Seviye2Bitir(){

        SeviyeYonetici.level3 = true;
        SceneManager.LoadScene(1);
    }
    public void Seviye3Bitir(){

        SeviyeYonetici.level4 = true;
        SceneManager.LoadScene(1);
    }
    public void Seviye4Bitir(){

        SeviyeYonetici.level5 = true;
        SceneManager.LoadScene(1);
    }
    public void Seviye5Bitir(){

        SceneManager.LoadScene(1);
    }
   

}
