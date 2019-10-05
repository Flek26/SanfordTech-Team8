using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleBodyParts : MonoBehaviour
{
    Toggle m_Toggle;
    public GameObject m_obj;
    public GameObject m_obj2;
    public GameObject m_obj3;

    void Start()
    {
        //Fetch the Toggle GameObject
        m_Toggle = GetComponent<Toggle>();
        //Add listener for when the state of the Toggle changes, and output the state
        m_Toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(m_Toggle);
        });
    }

    //Output the new state of the Toggle into Text when the user uses the Toggle
    void ToggleValueChanged(Toggle change)
    {
        m_obj.SetActive(!m_obj.activeSelf);
        m_obj2.SetActive(!m_obj2.activeSelf);
        m_obj3.SetActive(!m_obj3.activeSelf);
    }
}
