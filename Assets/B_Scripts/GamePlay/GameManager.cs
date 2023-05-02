using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState
{
    idle, ready, play, clear, fail
}
public class GameManager : MonoBehaviour
{
    GameState gstate;
    public Slider leftTimeSlider;
    void Start()
    {
        gstate = GameState.idle;
        leftTimeSlider.minValue = 0;
        leftTimeSlider.maxValue = GameData.limitTime;
        leftTimeSlider.value = GameData.limitTime;
    }

    // Update is called once per frame
    void Update()
    {
        TimeFliesLikeAnArrow();
        GameFlow();
        GameRule();
    }

    void TimeFliesLikeAnArrow()
    {
        GameData.limitTime -= Time.deltaTime;
        leftTimeSlider.value = GameData.limitTime;
    }

    void GameFlow()
    {
        switch (gstate)
        {
            case GameState.idle:
                break;

            case GameState.ready:
                break;

            case GameState.play:
                break;

            case GameState.clear:

                break;
            case GameState.fail:

                break;
        }
    }

    // Game Rule Check.
    // ������ �÷��� ���� ��� ������ Ŭ�������� ���ӿ��������� �����մϴ�.
    // �� �浹 ��Ȳ �̺�Ʈ, �ð� �ʰ� �̺�Ʈ, ���� ���� �������� �����ϰڽ��ϴ�.
    void GameRule()
    {
        switch (gstate)
        {
            case GameState.play:
                
                break;
        }
    }
}
