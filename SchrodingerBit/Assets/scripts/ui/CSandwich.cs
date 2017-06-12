using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CSandwich : MonoBehaviour
{
    public static Image m_changeHito;    // 表示される画像
    public static int m_imageStatus;
    public static SpriteState m_a;

    public GameObject obj;               // 画像の入ったオブジェクト(プレハブなど)

    public bool m_sandFlg = false;

    private Button m_hasamu;

    public SpriteState m_SandImagehito;
    public char kani;       // 区切りで入れてる
    public SpriteState m_SandImageKani;
    public char kuwagata;   // 区切りで入れてる
    public SpriteState m_SandImagekuwagata;


    void Start()
    {
        m_changeHito = obj.GetComponent<Image>();

        m_hasamu = GameObject.Find("hasamu").GetComponent<Button>();
    }


    void Update()
    {

    }


    public void ButtonPush()
    {
        Debug.Log(":"+CImage.m_imageStatus);

        if (CImage.m_imageStatus == 0)
        {
            m_hasamu.spriteState = m_SandImagehito;
            Debug.Log("hito");
        }
        if(CImage.m_imageStatus == 1)
        {
            m_hasamu.spriteState = m_SandImageKani;
            Debug.Log("kani");
        }
        if (CImage.m_imageStatus == 2)
        {
            m_hasamu.spriteState = m_SandImagekuwagata;
            Debug.Log("kuwagata");
        }


        if (m_sandFlg == false)
        {
            m_sandFlg = true;
            Debug.Log("はさむ");
        }
        else if (m_sandFlg == true)
        {
            m_sandFlg = false;
            Debug.Log("置く");
        }
        //Debug.Log(m_sandFlg);

    }
}
