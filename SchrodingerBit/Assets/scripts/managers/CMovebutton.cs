using UnityEngine;
using System.Collections;

public class CMovebutton : MonoBehaviour
{
    // 初期化
    bool m_downFlg  = false;
    bool m_upFlg    = false;
    bool m_rigthFlg = false;
    bool m_leftFlg  = false;

    bool m_upPush    = false;
    bool m_downPush  = false;
    bool m_rigthPush = false;
    bool m_leftPush  = false;

    public int m_pushCnt = 0;


    // ↑ キーが押された時
    public void upPushDown()
    {
        if(m_upPush == false)m_upPush = true;
    }
    // ↓ キーが押された時
    public void downPushDown()
    {
        if(m_downPush == false)m_downPush = true;
    }
    // → キーが押された時
    public void rigthPushDown()
    {
        if (m_rigthPush == false) m_rigthPush = true;
    }
    // ← キーが押された時
    public void leftPushDown()
    {
        if (m_leftPush == false) m_leftPush = true;
    }


    /*
    // ↑ キーが押されていない時
    public void upPushUp()
    {
        m_upPush = false;
    }
    // ↓ キーが押されていない時
    public void downPushUp()
    {
         m_downPush = false;
    }
    // → キーが押されていない時
    public void rigthPushUp()
    {
         m_rigthPush = false;
    }
    // ← キーが押されていない時
    public void leftPushUp()
    {
         m_leftPush = false;
    }
    */


    void Update()
    {
        if (m_upPush == true)
        {
            Debug.Log("up");
            m_upFlg  = true;
            m_upPush = false;
        }
        if (m_downPush == true)
        {
            Debug.Log("down");

            m_downFlg  = true;
            m_downPush = false;
        }
        if (m_rigthPush == true)
        {
            Debug.Log("rigth");

            m_rigthFlg  = true;
            m_rigthPush = false;
        }
        if (m_leftPush == true)
        {
            Debug.Log("left");

            m_leftFlg  = true;
            m_leftPush = false;
        }

    }

}

