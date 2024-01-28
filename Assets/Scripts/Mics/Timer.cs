using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI myTimerText;
    private float timer = 30;

    private void Start()
    {
        myTimerText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        CountDown();
        myTimerText.text = timer.ToString();
    }

    private void CountDown()
    {
        if(timer > 0)
        {
           timer -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
