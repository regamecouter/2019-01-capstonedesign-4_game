﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Uicontroller : MonoBehaviour
{

    //게임에 필요한 오브젝트를 생성

    public Text quizuitext;
    public Text outtext;
    public Text cleartext;

    public static bool Quiz;
    public static bool Out;
    public static bool Clear;
    public static bool info;
    public static bool info2;
    public static bool info3;
    public static bool info4;
    public static bool item1;
    public static bool item2;
    public static bool item3;
    public static bool getitem1;
    public static bool getitem2;
    public static bool getitem3;

    public GameObject information;
    public GameObject information2;
    public GameObject information3;
    public GameObject information4;

    public GameObject returnbutton;

    public GameObject quizuibutton;
    public GameObject quizuibutton2;
    public GameObject quizuibutton3;
    public GameObject quizuibutton4;
    public GameObject quizuipanel;

    public GameObject outbutton;
    public GameObject outpanel;

    public GameObject clearbutton;
    public GameObject clearpanel;

    public GameObject titlebutton;


    public GameObject quiz1;
    public GameObject quiz2;
    public GameObject quiz3;
    public GameObject quiz4;

    public GameObject quizbox1;
    public GameObject quizbox2;
    public GameObject quizbox3;
    public GameObject quizbox4;


    public GameObject infobox1;
    public GameObject infobox2;
    public GameObject infobox3;
    public GameObject infobox4;

    public GameObject inventory;

    public GameObject inventoryitem1;
    public GameObject inventoryitem2;
    public GameObject inventoryitem3;

    public GameObject grounditem1;
    public GameObject grounditem2;
    public GameObject grounditem3;

    public GameObject iteminfo1;
    public GameObject iteminfo2;
    public GameObject iteminfo3;

    public GameObject clearzone;

    public int invstatus;
    public int clearcount = 0;

    //UI 화면을 게임 시작시 보이지 않게 함

    void Start()
   {
        Quiz = false;
        Out = false;
        Clear = false;

        getitem1 = false;
        getitem2 = false;
        getitem3 = false;

        quizuitext.enabled = false;

        quizuibutton.SetActive(false);
        quizuibutton2.SetActive(false);
        quizuibutton3.SetActive(false);
        quizuibutton4.SetActive(false);

        quizuipanel.SetActive(false);

        quiz1.SetActive(false);
        quiz2.SetActive(false);
        quiz3.SetActive(false);
        quiz4.SetActive(false);

        outtext.enabled = false;
        outbutton.SetActive(false);
        outpanel.SetActive(false);

        cleartext.enabled = false;
        clearbutton.SetActive(false);
        clearpanel.SetActive(false);

        titlebutton.SetActive(false);

        information.SetActive(false);
        information2.SetActive(false);
        information3.SetActive(false);
        information4.SetActive(false);

        inventory.SetActive(false);
        inventoryitem1.SetActive(false);
        inventoryitem2.SetActive(false);
        inventoryitem3.SetActive(false);

        iteminfo1.SetActive(false);
        iteminfo2.SetActive(false);
        iteminfo3.SetActive(false);

        clearzone.SetActive(false);


        invstatus = 0;

        Time.timeScale = 1;
    }

    // 퀴즈나 팁에 닿았을 때 UI가 나오도록 설정함
    // 인게임 시간도 일시 정지됨

    void Update()
    {
        if (Quiz)
        {
            quizuitext.enabled = true;

             if (quizbox3 == null)
            {
                quizuibutton4.SetActive(true);
            }
            else if (quizbox2 == null)
            {
                quizuibutton3.SetActive(true);
            }
            else if (quizbox1 == null)
            {
                quizuibutton2.SetActive(true);
            }
            else
            {
                quizuibutton.SetActive(true);
            }
            quizuipanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (Out)
        {
            outtext.enabled = true;
            outbutton.SetActive(true);
            outpanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (Clear)
        {
            cleartext.enabled = true;
            clearbutton.SetActive(true);
            clearpanel.SetActive(true);
            titlebutton.SetActive(true);
            Time.timeScale = 0;
        }
        if (info)

        {
            information.SetActive(true);
            Time.timeScale = 0;
        }
        if (info2)

        {
            information2.SetActive(true);
            Time.timeScale = 0;
        }
        if (info3)

        {
            information3.SetActive(true);
            Time.timeScale = 0;
        }
        if (info4)

        {
            information4.SetActive(true);
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            if(invstatus == 0 )
            {
                invstatus = 1;
                inventory.SetActive(true);
            }
            else
            {
                inventory.SetActive(false);
                invstatus = 0;
            }
        }

        if (item1)
        {
            iteminfo1.SetActive(true);
            Time.timeScale = 0;
        }
        else if (item2)
        {
            iteminfo2.SetActive(true);
            Time.timeScale = 0;
        }
        else if (item3)
        {
            iteminfo3.SetActive(true);
            Time.timeScale = 0;
        }

        if (getitem1)
        {
            inventoryitem1.SetActive(true);
            if (inventoryitem2.activeSelf == true)
            {
                inventoryitem2.SetActive(true);
            }
            if (inventoryitem3.activeSelf == true)
            {
                inventoryitem3.SetActive(true);
            }
        }
        if (getitem2)
        {
            inventoryitem2.SetActive(true);
            if (inventoryitem1.activeSelf == true)
            {
                inventoryitem1.SetActive(true);
            }
            if (inventoryitem3.activeSelf == true)
            {
                inventoryitem3.SetActive(true);
            }
        }
        if (getitem3)
        {
            inventoryitem3.SetActive(true);
            if (inventoryitem1.activeSelf == true)
            {
                inventoryitem1.SetActive(true);
            }
            if (inventoryitem2.activeSelf == true)
            {
                inventoryitem2.SetActive(true);
            }
        }

        if (quizbox4 == null)
        {
            clearzone.SetActive(true);
        }

    }

    public void playquiz1()
    {
        quiz1.SetActive(true);
        Time.timeScale = 0;
    }
    public void playquiz2()
    {
        quiz2.SetActive(true);
        Time.timeScale = 0;
    }
    public void playquiz3()
    {
        quiz3.SetActive(true);
        Time.timeScale = 0;
    }
    public void playquiz4()
    {
        quiz4.SetActive(true);
        Time.timeScale = 0;
    }

    // 퀴즈를 맞추었을 경우 인게임 시간이 흐르고
    // 퀴즈 오브젝트는 파괴됨
    public void quizcorrect()
    {
        Quiz = false;
        if (quizbox3 == null)
        {
            Destroy(quizbox4);
            quiz4.SetActive(false);
            quizuibutton4.SetActive(false);
        }
        else if (quizbox2 == null)
        {
            Destroy(quizbox3);
            quiz3.SetActive(false);
            quizuibutton3.SetActive(false);
        }
        else if (quizbox1 == null)
        {
            Destroy(quizbox2);
            quiz2.SetActive(false);
            quizuibutton2.SetActive(false);
        }
        else
        {
            Destroy(quizbox1);
            quiz1.SetActive(false);
            quizuibutton.SetActive(false);
        }
        quizuitext.enabled = false;
        quizuipanel.SetActive(false);

        Time.timeScale = 1;
    }
    // 퀴즈를 틀렸을 경우 게임 오버가 됨
    public void quizwrong()
    {
        Quiz = false;

        quiz1.SetActive(false);
        quiz2.SetActive(false);
        quiz3.SetActive(false);
        quiz4.SetActive(false);

        quizuitext.enabled = false;
        quizuibutton.SetActive(false);
        quizuibutton2.SetActive(false);
        quizuibutton3.SetActive(false);
        quizuibutton4.SetActive(false);
        quizuipanel.SetActive(false);

        Out = true;
    }

    public void continuegame()
    {
        info = false;
        info2 = false;
        info3 = false;
        info4 = false;

        information.SetActive(false);
        information2.SetActive(false);
        information3.SetActive(false);
        information4.SetActive(false);

        Time.timeScale = 1;
    }
    public void continueitem1()
    {
        item1 = false;
        getitem1 = true;
        grounditem1.SetActive(false);
        iteminfo1.SetActive(false);
        Time.timeScale = 1;
    }
    public void continueitem2()
    {
        item2 = false;
        getitem2 = true;
        grounditem2.SetActive(false);
        iteminfo2.SetActive(false);
        Time.timeScale = 1;
    }
    public void continueitem3()
    {
        item3 = false;
        getitem3 = true;
        grounditem3.SetActive(false);
        iteminfo3.SetActive(false);
        Time.timeScale = 1;

    }
}

