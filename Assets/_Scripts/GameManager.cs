using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    public class ScoreChangeEvent : UnityEvent<string> { };
    public static ScoreChangeEvent OnScoreChange = new ScoreChangeEvent();

    public class EnegryChangeEvent : UnityEvent<float> { };
    public static EnegryChangeEvent OnEnergyChange = new EnegryChangeEvent();

    public class LevelProgressEvent : UnityEvent<float> { };
    public static LevelProgressEvent OnProgressChange = new LevelProgressEvent();

    public class EnemyKillEvent : UnityEvent<float> { };
    public static EnemyKillEvent OnEnemyKill = new EnemyKillEvent();

    public class LevelCompleteEvent : UnityEvent { };
    public static LevelCompleteEvent OnLevelComplete = new LevelCompleteEvent();

    public Transform levelFinish;

    public bool GameStartBool = false;

    [SerializeField] private float levelProgress;
    public float LevelProgress
    {
        get
        {
            return levelProgress;
        }

        set
        {
            if(Mathf.Abs(value - levelProgress)>0)
            {
                levelProgress = value;
                OnProgressChange.Invoke(value);
            }
        }
    }


    [SerializeField]
    private float score = 0;
    public float Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            OnScoreChange.Invoke(value.ToString());
          
        }
    }

   

  
 
    private void Start()
    {
        LevelProgress = 0;
        Score = 0;
        OnEnemyKill.AddListener(EnemyKilled);
        OnLevelComplete.AddListener(LevelCompleteHandler);
    }


    private void Update()
    {
        LevelProgress = 1f -Mathf.Abs(levelFinish.position.z- PlayerController.playerTransform.position.z) / levelFinish.position.z;
    }

    private void EnemyKilled(float killScore)
    {
        Score += killScore;
    }

    private void LevelCompleteHandler()
    {
        FunctionHandler.Instance.LevelComplete();
    }
}
