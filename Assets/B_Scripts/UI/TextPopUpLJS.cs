using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TextPopUpLJS : MonoBehaviour
{
    TextMeshProUGUI mission;
    string missionText = "산소 생성기가 고장났다! \n\n 우주 별자리 퍼즐을 맞춰 \n 수리 장비를 획득하라!";

    int TextIndex = 0;
    void Start()
    {
        mission = GetComponent<TextMeshProUGUI>();
        ShowText();
        //mission.text = missionText;
    }

    void Update()
    {
    }

    void ShowText()
    {
        if (TextIndex < missionText.Length)
        {
            mission.text = missionText.Substring(0, TextIndex + 1);
            TextIndex++;
            Invoke("ShowText", 0.1f);
        }
        else return;
    }
}
