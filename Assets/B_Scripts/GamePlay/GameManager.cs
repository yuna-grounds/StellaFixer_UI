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
    // 게임이 플레이 중인 경우 게임이 클리어인지 게임오버인지를 결정합니다.
    // 적 충돌 상황 이벤트, 시간 초과 이벤트, 성공 등을 로직으로 구현하겠습니다.
    void GameRule()
    {
        switch (gstate)
        {
            case GameState.play:
                
                break;
        }
    }
}
