using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITextUpdater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.OnScoreChange.AddListener(UpdateText);
    }

    private void OnEnable()
    {
       UpdateText(GameManager.Instance.Score.ToString());
    }

    // Update is called once per frame
    void UpdateText(string text)
    {
        transform.GetComponent<TextMeshProUGUI>().text = text;
    }
}

