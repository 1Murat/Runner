using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CheckPointSystem : MonoBehaviour
{
    [Header("Players")]
    public Transform Player1;
    public Transform Player2;
    public Transform Player3;
    public Transform Player4;
    public Transform Player5;
    public Transform Player6;
    public Transform Player7;
    public Transform Player8;
    public Transform Player9;
    public Transform Player10;
    public Transform Player11;

    [Header("Distances")]
    public float player1Dist;
    public float player2Dist;
    public float player3Dist;
    public float player4Dist;
    public float player5Dist;
    public float player6Dist;
    public float player7Dist;
    public float player8Dist;
    public float player9Dist;
    public float player10Dist;
    public float player11Dist;

    [Header("Placement")]
    public float first;
    public float eleventh;
    public float second;
    public float third;
    public float fourth;
    public float fifth;
    public float sixth;
    public float seventh;
    public float Eighth;
    public float ninth;
    public float tenth;
    
    [Header("Settings")]
    public TextMeshProUGUI PlayerPosDisplay;
    public int playerPos;


    
    void Update()
    {
        player1Dist = Vector3.Distance(transform.position, Player1.position);
        player2Dist = Vector3.Distance(transform.position, Player2.position);
        player3Dist = Vector3.Distance(transform.position, Player3.position);
        player4Dist = Vector3.Distance(transform.position, Player4.position);
        player5Dist = Vector3.Distance(transform.position, Player5.position);
        player6Dist = Vector3.Distance(transform.position, Player6.position);
        player7Dist = Vector3.Distance(transform.position, Player7.position);
        player8Dist = Vector3.Distance(transform.position, Player8.position);
        player9Dist = Vector3.Distance(transform.position, Player9.position);
        player10Dist = Vector3.Distance(transform.position, Player10.position);
        player11Dist = Vector3.Distance(transform.position, Player11.position);


        first = Mathf.Min(player1Dist, player2Dist, player3Dist, player4Dist, player5Dist, player6Dist, player7Dist, player8Dist, player9Dist, player10Dist, player11Dist);
        
        eleventh = Mathf.Max(player1Dist, player2Dist,player3Dist, player4Dist, player5Dist, player6Dist, player7Dist, player8Dist, player9Dist, player10Dist, player11Dist);

        #region tenth

        if(player1Dist < eleventh && player1Dist > first){
            tenth = player1Dist;
        }
        if(player2Dist < eleventh && player2Dist > first){
            tenth = player2Dist;
        }
        if(player3Dist < eleventh && player3Dist > first){
            tenth = player3Dist;
        }
        if(player4Dist < eleventh && player4Dist > first){
            tenth = player4Dist;
        }
        if(player5Dist < eleventh && player5Dist > first){
            tenth = player5Dist;
        }
        if(player6Dist < eleventh && player6Dist > first){
            tenth = player6Dist;
        }
        if(player7Dist < eleventh && player7Dist > first){
            tenth = player7Dist;
        }
        if(player8Dist < eleventh && player8Dist > first){
            tenth = player8Dist;
        }
        if(player9Dist < eleventh && player9Dist > first){
            tenth = player9Dist;
        }
        if(player10Dist < eleventh && player10Dist > first){
            tenth = player10Dist;
        }
         if(player11Dist < eleventh && player11Dist > first){
            tenth = player11Dist;
        }
        #endregion



        #region second

        if(player1Dist !=first && player1Dist !=third && player1Dist != fourth && player1Dist != fifth && player1Dist!= sixth && player1Dist!= seventh && player1Dist != Eighth && player1Dist!= ninth && player1Dist!= tenth && player1Dist !=eleventh){
            second = player1Dist;
        }
        if(player2Dist !=first && player2Dist !=third && player2Dist != fourth && player2Dist != fifth && player2Dist!= sixth && player2Dist!= seventh && player2Dist != Eighth && player2Dist!= ninth && player2Dist!= tenth && player2Dist !=eleventh){
            second = player2Dist;
        }
        if(player3Dist !=first && player3Dist !=third && player3Dist != fourth && player3Dist != fifth && player3Dist!= sixth && player3Dist!= seventh && player3Dist != Eighth && player3Dist!= ninth && player3Dist!= tenth && player3Dist !=eleventh){
            second = player3Dist;
        }
        if(player4Dist !=first && player4Dist !=third && player4Dist != fourth && player4Dist != fifth && player4Dist!= sixth && player4Dist!= seventh && player4Dist != Eighth && player4Dist!= ninth && player4Dist!= tenth && player4Dist !=eleventh){
            second = player4Dist;
        }
        if(player5Dist !=first && player5Dist !=third && player5Dist != fourth && player5Dist != fifth && player5Dist!= sixth && player5Dist!= seventh && player5Dist != Eighth && player5Dist!= ninth && player5Dist!= tenth && player5Dist !=eleventh){
            second = player5Dist;
        }
        if(player6Dist !=first && player6Dist !=third && player6Dist != fourth && player6Dist != fifth && player6Dist!= sixth && player6Dist!= seventh && player6Dist != Eighth && player6Dist!= ninth && player6Dist!= tenth && player6Dist !=eleventh){
            second = player6Dist;
        }
        if(player7Dist !=first && player7Dist !=third && player7Dist != fourth && player7Dist != fifth && player7Dist!= sixth && player7Dist!= seventh && player7Dist != Eighth && player7Dist!= ninth && player7Dist!= tenth && player7Dist !=eleventh){
            second = player7Dist;
        }
        if(player8Dist !=first && player8Dist !=third && player8Dist != fourth && player8Dist != fifth && player8Dist!= sixth && player8Dist!= seventh && player8Dist != Eighth && player8Dist!= ninth && player8Dist!= tenth && player8Dist !=eleventh){
            second = player8Dist;
        }
        if(player9Dist !=first && player9Dist !=third && player9Dist != fourth && player9Dist != fifth && player9Dist!= sixth && player9Dist!= seventh && player9Dist != Eighth && player9Dist!= ninth && player9Dist!= tenth && player9Dist !=eleventh){
            second = player9Dist;
        }
        if(player10Dist !=first && player10Dist !=third && player10Dist != fourth && player10Dist != fifth && player10Dist!= sixth && player10Dist!= seventh && player10Dist != Eighth && player10Dist!= ninth && player10Dist!= tenth && player10Dist !=eleventh){
            second = player10Dist;
        }
        if(player11Dist !=first && player11Dist !=third && player11Dist != fourth && player11Dist != fifth && player11Dist!= sixth && player11Dist!= seventh && player11Dist != Eighth && player11Dist!= ninth && player11Dist!= tenth && player11Dist !=eleventh){
            second = player11Dist;
        }

        #endregion

        
        #region third

         if(player1Dist !=first && player1Dist !=second && player1Dist != fourth && player1Dist != fifth && player1Dist!= sixth && player1Dist!= seventh && player1Dist != Eighth && player1Dist!= ninth && player1Dist!= tenth && player1Dist !=eleventh){
            third= player1Dist;
        }
        if(player2Dist !=first && player2Dist !=second && player2Dist != fourth && player2Dist != fifth && player2Dist!= sixth && player2Dist!= seventh && player2Dist != Eighth && player2Dist!= ninth && player2Dist!= tenth && player2Dist !=eleventh){
            third= player2Dist;
        }
        if(player3Dist !=first && player3Dist !=second && player3Dist != fourth && player3Dist != fifth && player3Dist!= sixth && player3Dist!= seventh && player3Dist != Eighth && player3Dist!= ninth && player3Dist!= tenth && player3Dist !=eleventh){
            third = player3Dist;
        }
        if(player4Dist !=first && player4Dist !=second && player4Dist != fourth && player4Dist != fifth && player4Dist!= sixth && player4Dist!= seventh && player4Dist != Eighth && player4Dist!= ninth && player4Dist!= tenth && player4Dist !=eleventh){
            third = player4Dist;
        }
        if(player5Dist !=first && player5Dist !=second && player5Dist != fourth && player5Dist != fifth && player5Dist!= sixth && player5Dist!= seventh && player5Dist != Eighth && player5Dist!= ninth && player5Dist!= tenth && player5Dist !=eleventh){
            third = player5Dist;
        }
        if(player6Dist !=first && player6Dist !=second && player6Dist != fourth && player6Dist != fifth && player6Dist!= sixth && player6Dist!= seventh && player6Dist != Eighth && player6Dist!= ninth && player6Dist!= tenth && player6Dist !=eleventh){
            third = player6Dist;
        }
        if(player7Dist !=first && player7Dist !=second && player7Dist != fourth && player7Dist != fifth && player7Dist!= sixth && player7Dist!= seventh && player7Dist != Eighth && player7Dist!= ninth && player7Dist!= tenth && player7Dist !=eleventh){
            third = player7Dist;
        }
        if(player8Dist !=first && player8Dist !=second && player8Dist != fourth && player8Dist != fifth && player8Dist!= sixth && player8Dist!= seventh && player8Dist != Eighth && player8Dist!= ninth && player8Dist!= tenth && player8Dist !=eleventh){
            third = player8Dist;
        }
        if(player9Dist !=first && player9Dist !=second && player9Dist != fourth && player9Dist != fifth && player9Dist!= sixth && player9Dist!= seventh && player9Dist != Eighth && player9Dist!= ninth && player9Dist!= tenth && player9Dist !=eleventh){
            third = player9Dist;
        }
        if(player10Dist !=first && player10Dist !=second && player10Dist != fourth && player10Dist != fifth && player10Dist!= sixth && player10Dist!= seventh && player10Dist != Eighth && player10Dist!= ninth && player10Dist!= tenth && player10Dist !=eleventh){
            third = player10Dist;
        }
        if(player11Dist !=first && player11Dist !=second && player11Dist != fourth && player11Dist != fifth && player11Dist!= sixth && player11Dist!= seventh && player11Dist != Eighth && player11Dist!= ninth && player11Dist!= tenth && player11Dist !=eleventh){
            third = player11Dist;
        }

        #endregion



        #region fourth

         if(player1Dist !=first && player1Dist !=second && player1Dist != third && player1Dist != fifth && player1Dist!= sixth && player1Dist!= seventh && player1Dist != Eighth && player1Dist!= ninth && player1Dist!= tenth && player1Dist !=eleventh){
            fourth= player1Dist;
        }
        if(player2Dist !=first && player2Dist !=second && player2Dist != third && player2Dist != fifth && player2Dist!= sixth && player2Dist!= seventh && player2Dist != Eighth && player2Dist!= ninth && player2Dist!= tenth && player2Dist !=eleventh){
            fourth= player2Dist;
        }
        if(player3Dist !=first && player3Dist !=second && player3Dist != third && player3Dist != fifth && player3Dist!= sixth && player3Dist!= seventh && player3Dist != Eighth && player3Dist!= ninth && player3Dist!= tenth && player3Dist !=eleventh){
            fourth = player3Dist;
        }
        if(player4Dist !=first && player4Dist !=second && player4Dist != third && player4Dist != fifth && player4Dist!= sixth && player4Dist!= seventh && player4Dist != Eighth && player4Dist!= ninth && player4Dist!= tenth && player4Dist !=eleventh){
            fourth = player4Dist;
        }
        if(player5Dist !=first && player5Dist !=second && player5Dist != third && player5Dist != fifth && player5Dist!= sixth && player5Dist!= seventh && player5Dist != Eighth && player5Dist!= ninth && player5Dist!= tenth && player5Dist !=eleventh){
            fourth = player5Dist;
        }
        if(player6Dist !=first && player6Dist !=second && player6Dist != third && player6Dist != fifth && player6Dist!= sixth && player6Dist!= seventh && player6Dist != Eighth && player6Dist!= ninth && player6Dist!= tenth && player6Dist !=eleventh){
            fourth = player6Dist;
        }
        if(player7Dist !=first && player7Dist !=second && player7Dist != third && player7Dist != fifth && player7Dist!= sixth && player7Dist!= seventh && player7Dist != Eighth && player7Dist!= ninth && player7Dist!= tenth && player7Dist !=eleventh){
            fourth = player7Dist;
        }
        if(player8Dist !=first && player8Dist !=second && player8Dist != third && player8Dist != fifth && player8Dist!= sixth && player8Dist!= seventh && player8Dist != Eighth && player8Dist!= ninth && player8Dist!= tenth && player8Dist !=eleventh){
            fourth = player8Dist;
        }
        if(player9Dist !=first && player9Dist !=second && player9Dist != third && player9Dist != fifth && player9Dist!= sixth && player9Dist!= seventh && player9Dist != Eighth && player9Dist!= ninth && player9Dist!= tenth && player9Dist !=eleventh){
            fourth = player9Dist;
        }
        if(player10Dist !=first && player10Dist !=second && player10Dist != third && player10Dist != fifth && player10Dist!= sixth && player10Dist!= seventh && player10Dist != Eighth && player10Dist!= ninth && player10Dist!= tenth && player10Dist !=eleventh){
            fourth = player10Dist;
        }
        if(player11Dist !=first && player11Dist !=second && player11Dist != third && player11Dist != fifth && player11Dist!= sixth && player11Dist!= seventh && player11Dist != Eighth && player11Dist!= ninth && player11Dist!= tenth && player11Dist !=eleventh){
            fourth = player11Dist;
        }


        #endregion


        #region fifth

        if(player1Dist !=first && player1Dist !=second && player1Dist != third && player1Dist != fourth && player1Dist!= sixth && player1Dist!= seventh && player1Dist != Eighth && player1Dist!= ninth && player1Dist!= tenth && player1Dist !=eleventh){
           fifth= player1Dist;
        }
        if(player2Dist !=first && player2Dist !=second && player2Dist != third && player2Dist != fourth && player2Dist!= sixth && player2Dist!= seventh && player2Dist != Eighth && player2Dist!= ninth && player2Dist!= tenth && player2Dist !=eleventh){
            fifth= player2Dist;
        }
        if(player3Dist !=first && player3Dist !=second && player3Dist != third && player3Dist != fourth && player3Dist!= sixth && player3Dist!= seventh && player3Dist != Eighth && player3Dist!= ninth && player3Dist!= tenth && player3Dist !=eleventh){
            fifth = player3Dist;
        }
        if(player4Dist !=first && player4Dist !=second && player4Dist != third && player4Dist != fourth && player4Dist!= sixth && player4Dist!= seventh && player4Dist != Eighth && player4Dist!= ninth && player4Dist!= tenth && player4Dist !=eleventh){
            fifth = player4Dist;
        }
        if(player5Dist !=first && player5Dist !=second && player5Dist != third && player5Dist != fourth && player5Dist!= sixth && player5Dist!= seventh && player5Dist != Eighth && player5Dist!= ninth && player5Dist!= tenth && player5Dist !=eleventh){
            fifth = player5Dist;
        }
        if(player6Dist !=first && player6Dist !=second && player6Dist != third && player6Dist != fourth && player6Dist!= sixth && player6Dist!= seventh && player6Dist != Eighth && player6Dist!= ninth && player6Dist!= tenth && player6Dist !=eleventh){
            fifth = player6Dist;
        }
        if(player7Dist !=first && player7Dist !=second && player7Dist != third && player7Dist != fourth && player7Dist!= sixth && player7Dist!= seventh && player7Dist != Eighth && player7Dist!= ninth && player7Dist!= tenth && player7Dist !=eleventh){
            fifth = player7Dist;
        }
        if(player8Dist !=first && player8Dist !=second && player8Dist != third && player8Dist != fourth && player8Dist!= sixth && player8Dist!= seventh && player8Dist != Eighth && player8Dist!= ninth && player8Dist!= tenth && player8Dist !=eleventh){
            fifth = player8Dist;
        }
        if(player9Dist !=first && player9Dist !=second && player9Dist != third && player9Dist != fourth && player9Dist!= sixth && player9Dist!= seventh && player9Dist != Eighth && player9Dist!= ninth && player9Dist!= tenth && player9Dist !=eleventh){
            fifth = player9Dist;
        }
        if(player10Dist !=first && player10Dist !=second && player10Dist != third && player10Dist != fourth && player10Dist!= sixth && player10Dist!= seventh && player10Dist != Eighth && player10Dist!= ninth && player10Dist!= tenth && player10Dist !=eleventh){
            fifth = player10Dist;
        }
        if(player11Dist !=first && player11Dist !=second && player11Dist != third && player11Dist != fourth && player11Dist!= sixth && player11Dist!= seventh && player11Dist != Eighth && player11Dist!= ninth && player11Dist!= tenth && player11Dist !=eleventh){
            fifth = player11Dist;
        }


        #endregion

       
       
       
        #region  sixth

        if(player1Dist !=first && player1Dist !=second && player1Dist != third && player1Dist != fourth && player1Dist!= fifth && player1Dist!= seventh && player1Dist != Eighth && player1Dist!= ninth && player1Dist!= tenth && player1Dist !=eleventh){
           sixth = player1Dist;
        }
        if(player2Dist !=first && player2Dist !=second && player2Dist != third && player2Dist != fourth && player2Dist!= fifth && player2Dist!= seventh && player2Dist != Eighth && player2Dist!= ninth && player2Dist!= tenth && player2Dist !=eleventh){
            sixth= player2Dist;
        }
        if(player3Dist !=first && player3Dist !=second && player3Dist != third && player3Dist != fourth && player3Dist!= fifth && player3Dist!= seventh && player3Dist != Eighth && player3Dist!= ninth && player3Dist!= tenth && player3Dist !=eleventh){
            sixth = player3Dist;
        }
        if(player4Dist !=first && player4Dist !=second && player4Dist != third && player4Dist != fourth && player4Dist!= fifth && player4Dist!= seventh && player4Dist != Eighth && player4Dist!= ninth && player4Dist!= tenth && player4Dist !=eleventh){
            sixth = player4Dist;
        }
        if(player5Dist !=first && player5Dist !=second && player5Dist != third && player5Dist != fourth && player5Dist!= fifth && player5Dist!= seventh && player5Dist != Eighth && player5Dist!= ninth && player5Dist!= tenth && player5Dist !=eleventh){
            sixth = player5Dist;
        }
        if(player6Dist !=first && player6Dist !=second && player6Dist != third && player6Dist != fourth && player6Dist!= fifth && player6Dist!= seventh && player6Dist != Eighth && player6Dist!= ninth && player6Dist!= tenth && player6Dist !=eleventh){
            sixth = player6Dist;
        }
        if(player7Dist !=first && player7Dist !=second && player7Dist != third && player7Dist != fourth && player7Dist!=fifth && player7Dist!= seventh && player7Dist != Eighth && player7Dist!= ninth && player7Dist!= tenth && player7Dist !=eleventh){
            sixth = player7Dist;
        }
        if(player8Dist !=first && player8Dist !=second && player8Dist != third && player8Dist != fourth && player8Dist!= fifth && player8Dist!= seventh && player8Dist != Eighth && player8Dist!= ninth && player8Dist!= tenth && player8Dist !=eleventh){
            sixth = player8Dist;
        }
        if(player9Dist !=first && player9Dist !=second && player9Dist != third && player9Dist != fourth && player9Dist!= fifth && player9Dist!= seventh && player9Dist != Eighth && player9Dist!= ninth && player9Dist!= tenth && player9Dist !=eleventh){
            sixth = player9Dist;
        }
        if(player10Dist !=first && player10Dist !=second && player10Dist != third && player10Dist != fourth && player10Dist!= fifth && player10Dist!= seventh && player10Dist != Eighth && player10Dist!= ninth && player10Dist!= tenth && player10Dist !=eleventh){
            sixth = player10Dist;
        }
        if(player11Dist !=first && player11Dist !=second && player11Dist != third && player11Dist != fourth && player11Dist!= fifth && player11Dist!= seventh && player11Dist != Eighth && player11Dist!= ninth && player11Dist!= tenth && player11Dist !=eleventh){
            sixth = player11Dist;
        }

        #endregion

        
        #region seventh
        
        if(player1Dist !=first && player1Dist !=second && player1Dist != third && player1Dist != fourth && player1Dist!= fifth && player1Dist!= sixth && player1Dist != Eighth && player1Dist!= ninth && player1Dist!= tenth && player1Dist !=eleventh){
           seventh = player1Dist;
        }
        if(player2Dist !=first && player2Dist !=second && player2Dist != third && player2Dist != fourth && player2Dist!= fifth && player2Dist!= sixth && player2Dist != Eighth && player2Dist!= ninth && player2Dist!= tenth && player2Dist !=eleventh){
            seventh = player2Dist;
        }
        if(player3Dist !=first && player3Dist !=second && player3Dist != third && player3Dist != fourth && player3Dist!= fifth && player3Dist!= sixth && player3Dist != Eighth && player3Dist!= ninth && player3Dist!= tenth && player3Dist !=eleventh){
            seventh = player3Dist;
        }
        if(player4Dist !=first && player4Dist !=second && player4Dist != third && player4Dist != fourth && player4Dist!= fifth && player4Dist!= sixth && player4Dist != Eighth && player4Dist!= ninth && player4Dist!= tenth && player4Dist !=eleventh){
            seventh = player4Dist;
        }
        if(player5Dist !=first && player5Dist !=second && player5Dist != third && player5Dist != fourth && player5Dist!= fifth && player5Dist!= sixth && player5Dist != Eighth && player5Dist!= ninth && player5Dist!= tenth && player5Dist !=eleventh){
            seventh = player5Dist;
        }
        if(player6Dist !=first && player6Dist !=second && player6Dist != third && player6Dist != fourth && player6Dist!= fifth && player6Dist!= sixth && player6Dist != Eighth && player6Dist!= ninth && player6Dist!= tenth && player6Dist !=eleventh){
            seventh = player6Dist;
        }
        if(player7Dist !=first && player7Dist !=second && player7Dist != third && player7Dist != fourth && player7Dist!=fifth && player7Dist!= sixth && player7Dist != Eighth && player7Dist!= ninth && player7Dist!= tenth && player7Dist !=eleventh){
            seventh = player7Dist;
        }
        if(player8Dist !=first && player8Dist !=second && player8Dist != third && player8Dist != fourth && player8Dist!= fifth && player8Dist!= sixth && player8Dist != Eighth && player8Dist!= ninth && player8Dist!= tenth && player8Dist !=eleventh){
            seventh = player8Dist;
        }
        if(player9Dist !=first && player9Dist !=second && player9Dist != third && player9Dist != fourth && player9Dist!= fifth && player9Dist!= sixth && player9Dist != Eighth && player9Dist!= ninth && player9Dist!= tenth && player9Dist !=eleventh){
            seventh = player9Dist;
        }
        if(player10Dist !=first && player10Dist !=second && player10Dist != third && player10Dist != fourth && player10Dist!= fifth && player10Dist!= sixth && player10Dist != Eighth && player10Dist!= ninth && player10Dist!= tenth && player10Dist !=eleventh){
            seventh = player10Dist;
        }
        if(player11Dist !=first && player11Dist !=second && player11Dist != third && player11Dist != fourth && player11Dist!= fifth && player11Dist!= sixth && player11Dist != Eighth && player11Dist!= ninth && player11Dist!= tenth && player11Dist !=eleventh){
            seventh = player11Dist;
        }

        #endregion


        #region Eighth

        if(player1Dist !=first && player1Dist !=second && player1Dist != third && player1Dist != fourth && player1Dist!= fifth && player1Dist!= sixth && player1Dist != seventh && player1Dist!= ninth && player1Dist!= tenth && player1Dist !=eleventh){
           Eighth = player1Dist;
        }
        if(player2Dist !=first && player2Dist !=second && player2Dist != third && player2Dist != fourth && player2Dist!= fifth && player2Dist!= sixth && player2Dist != seventh && player2Dist!= ninth && player2Dist!= tenth && player2Dist !=eleventh){
           Eighth = player2Dist;
        }
        if(player3Dist !=first && player3Dist !=second && player3Dist != third && player3Dist != fourth && player3Dist!= fifth && player3Dist!= sixth && player3Dist != seventh && player3Dist!= ninth && player3Dist!= tenth && player3Dist !=eleventh){
            Eighth = player3Dist;
        }
        if(player4Dist !=first && player4Dist !=second && player4Dist != third && player4Dist != fourth && player4Dist!= fifth && player4Dist!= sixth && player4Dist != seventh && player4Dist!= ninth && player4Dist!= tenth && player4Dist !=eleventh){
            Eighth = player4Dist;
        }
        if(player5Dist !=first && player5Dist !=second && player5Dist != third && player5Dist != fourth && player5Dist!= fifth && player5Dist!= sixth && player5Dist != seventh && player5Dist!= ninth && player5Dist!= tenth && player5Dist !=eleventh){
            Eighth = player5Dist;
        }
        if(player6Dist !=first && player6Dist !=second && player6Dist != third && player6Dist != fourth && player6Dist!= fifth && player6Dist!= sixth && player6Dist != seventh && player6Dist!= ninth && player6Dist!= tenth && player6Dist !=eleventh){
            Eighth = player6Dist;
        }
        if(player7Dist !=first && player7Dist !=second && player7Dist != third && player7Dist != fourth && player7Dist!=fifth && player7Dist!= sixth && player7Dist != seventh && player7Dist!= ninth && player7Dist!= tenth && player7Dist !=eleventh){
            Eighth = player7Dist;
        }
        if(player8Dist !=first && player8Dist !=second && player8Dist != third && player8Dist != fourth && player8Dist!= fifth && player8Dist!= sixth && player8Dist != seventh && player8Dist!= ninth && player8Dist!= tenth && player8Dist !=eleventh){
            Eighth = player8Dist;
        }
        if(player9Dist !=first && player9Dist !=second && player9Dist != third && player9Dist != fourth && player9Dist!= fifth && player9Dist!= sixth && player9Dist != seventh && player9Dist!= ninth && player9Dist!= tenth && player9Dist !=eleventh){
            Eighth = player9Dist;
        }
        if(player10Dist !=first && player10Dist !=second && player10Dist != third && player10Dist != fourth && player10Dist!= fifth && player10Dist!= sixth && player10Dist != seventh && player10Dist!= ninth && player10Dist!= tenth && player10Dist !=eleventh){
            Eighth = player10Dist;
        }
        if(player11Dist !=first && player11Dist !=second && player11Dist != third && player11Dist != fourth && player11Dist!= fifth && player11Dist!= sixth && player11Dist != seventh && player11Dist!= ninth && player11Dist!= tenth && player11Dist !=eleventh){
            Eighth = player11Dist;
        }

        #endregion

        #region  ninth

        if(player1Dist !=first && player1Dist !=second && player1Dist != third && player1Dist != fourth && player1Dist!= fifth && player1Dist!= sixth && player1Dist != seventh && player1Dist!= Eighth && player1Dist!= tenth && player1Dist !=eleventh){
           ninth = player1Dist;
        }
        if(player2Dist !=first && player2Dist !=second && player2Dist != third && player2Dist != fourth && player2Dist!= fifth && player2Dist!= sixth && player2Dist != seventh && player2Dist!= Eighth && player2Dist!= tenth && player2Dist !=eleventh){
           ninth = player2Dist;
        }
        if(player3Dist !=first && player3Dist !=second && player3Dist != third && player3Dist != fourth && player3Dist!= fifth && player3Dist!= sixth && player3Dist != seventh && player3Dist!= Eighth && player3Dist!= tenth && player3Dist !=eleventh){
           ninth = player3Dist;
        }
        if(player4Dist !=first && player4Dist !=second && player4Dist != third && player4Dist != fourth && player4Dist!= fifth && player4Dist!= sixth && player4Dist != seventh && player4Dist!= Eighth && player4Dist!= tenth && player4Dist !=eleventh){
            ninth = player4Dist;
        }
        if(player5Dist !=first && player5Dist !=second && player5Dist != third && player5Dist != fourth && player5Dist!= fifth && player5Dist!= sixth && player5Dist != seventh && player5Dist!= Eighth && player5Dist!= tenth && player5Dist !=eleventh){
            ninth = player5Dist;
        }
        if(player6Dist !=first && player6Dist !=second && player6Dist != third && player6Dist != fourth && player6Dist!= fifth && player6Dist!= sixth && player6Dist != seventh && player6Dist!= Eighth && player6Dist!= tenth && player6Dist !=eleventh){
           ninth = player6Dist;
        }
        if(player7Dist !=first && player7Dist !=second && player7Dist != third && player7Dist != fourth && player7Dist!=fifth && player7Dist!= sixth && player7Dist != seventh && player7Dist!= Eighth && player7Dist!= tenth && player7Dist !=eleventh){
            ninth = player7Dist;
        }
        if(player8Dist !=first && player8Dist !=second && player8Dist != third && player8Dist != fourth && player8Dist!= fifth && player8Dist!= sixth && player8Dist != seventh && player8Dist!= Eighth && player8Dist!= tenth && player8Dist !=eleventh){
            ninth = player8Dist;
        }
        if(player9Dist !=first && player9Dist !=second && player9Dist != third && player9Dist != fourth && player9Dist!= fifth && player9Dist!= sixth && player9Dist != seventh && player9Dist!= Eighth && player9Dist!= tenth && player9Dist !=eleventh){
            ninth = player9Dist;
        }
        if(player10Dist !=first && player10Dist !=second && player10Dist != third && player10Dist != fourth && player10Dist!= fifth && player10Dist!= sixth && player10Dist != seventh && player10Dist!= Eighth && player10Dist!= tenth && player10Dist !=eleventh){
            ninth = player10Dist;
        }
        if(player11Dist !=first && player11Dist !=second && player11Dist != third && player11Dist != fourth && player11Dist!= fifth && player11Dist!= sixth && player11Dist != seventh && player11Dist!= Eighth && player11Dist!= tenth && player11Dist !=eleventh){
            ninth = player11Dist;
        }

        #endregion


        #region PlayerPosition

        if(player1Dist == first){
            playerPos = 1;
        }
        if(player1Dist == second){
            playerPos = 2;
        }
        if(player1Dist == third){
            playerPos = 3;
        }
        if(player1Dist == fourth){
            playerPos = 4;
        }
        if(player1Dist == fifth){
            playerPos = 5;
        }
        if(player1Dist == sixth){
            playerPos = 6;
        }
        if(player1Dist == seventh){
            playerPos = 7;
        }
        if(player1Dist == Eighth){
            playerPos = 8;
        }
        if(player1Dist == ninth){
            playerPos = 9;
        }
        if(player1Dist == tenth){
            playerPos = 10;
        }
        if(player1Dist == eleventh){
            playerPos = 11;
        }

        PlayerPosDisplay.text = playerPos + "/" + 11;

        #endregion
    }
}
