using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSandwich : MonoBehaviour
{

    public bool m_sandFlg = false;

    public void ButtonPush()
    {
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
