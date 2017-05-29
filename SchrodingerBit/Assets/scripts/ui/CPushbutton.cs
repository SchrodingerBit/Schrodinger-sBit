using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPushbutton : MonoBehaviour {

    // 初期化
    bool m_downFlg = false;
    bool m_upFlg = false;
    bool m_rigthFlg = false;
    bool m_leftFlg = false;

    // ↑ キーが押された時
    public void upPushDown()
    {
        if (m_upFlg == false) m_upFlg = true;
    }
    // ↓ キーが押された時
    public void downPushDown()
    {
        if (m_downFlg == false) m_downFlg = true;
    }
    // → キーが押された時
    public void rigthPushDown()
    {
        if (m_rigthFlg == false) m_rigthFlg = true;
    }
    // ← キーが押された時
    public void leftPushDown()
    {
        if (m_leftFlg == false) m_leftFlg = true;
    }


    // ↑ キーが押されてない時
    public void upPushUp()
    {
        if (m_upFlg == true) m_upFlg = false;
    }
    // ↓ キーが押されてない時
    public void downPushUp()
    {
        if (m_downFlg == true) m_downFlg = false;
    }
    // → キーが押されてない時
    public void rigthPushUp()
    {
        if (m_rigthFlg == true) m_rigthFlg = false;
    }
    // ← キーが押されてない時
    public void leftPushUp()
    {
        if (m_leftFlg == true) m_leftFlg = false;
    }



    //デバック用
    void Update()
    {
        if (m_upFlg == true)
        {
            Debug.Log("up");
        }
        if (m_downFlg == true)
        {
            Debug.Log("down");
        }
        if (m_rigthFlg == true)
        {
            Debug.Log("rigth");
        }
        if (m_leftFlg == true)
        {
            Debug.Log("left");
        }

    }
}
