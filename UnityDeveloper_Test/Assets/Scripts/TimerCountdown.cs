using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TimerCountdown : MonoBehaviour
{
    [SerializeField] float levelTime = 120f;
    private TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        timerText.text = levelTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        levelTime -= Time.deltaTime;
        timerText.text = levelTime.ToString("f2");
        if(levelTime <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
