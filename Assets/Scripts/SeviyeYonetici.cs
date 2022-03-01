using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeviyeYonetici : MonoBehaviour
{
    
    public Button level1_Button, level2_Button, level3_Button, level4_Button, level5_Button;
    public static bool level1, level2, level3, level4, level5;

    void Start() {
        
        level1 = true;      
        
    }

    void Update() {

        if(level2 == true){

            level2_Button.interactable = true;
        }

        if(level3 == true){

            level3_Button.interactable = true;
        }

        if(level4 == true){

            level4_Button.interactable = true;
        }

        if(level5 == true){

            level5_Button.interactable = true;
        }
        
    }
}
