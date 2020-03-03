using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    public float goal = 500;
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
            progression.value = score/goal;

            if (score/goal >=1)
            {
                FunctionHandler.Instance.LevelComplete();
            }
        }
    }

    public Slider progression;

    public bool GameStartBool = false;

    public Transform pressRef;
    public Transform targetRef;

    public Transform pressLower;
    public Transform pressUpper;

    public float speed = 1f;
    public float upperSpeed = 0.2f;
    public float pressUpperLimit;

    public bool upperBool = false;



    public Transform brigde;
    public float bridgeSpeed = 1f;

    private void Start()
    {
        //pressUpperLimit = pressUpper.position.y;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameStartBool = !GameStartBool;
        }

        if(GameStartBool)
        {
            //Scroll the bridge
            brigde.Translate(Vector3.back * bridgeSpeed * Time.deltaTime);
        }
        


        
    }
}
