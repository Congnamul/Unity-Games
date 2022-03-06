using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Gamemanager : MonoBehaviour
{

    public GameObject Reset;
    public Text timeText;
    public Text recordText;

    private float survibeTime;
    private bool isGameover;


    // Start is called before the first frame update
    void Start()
    {
        survibeTime = 0f;
        isGameover = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameover)
        {
            survibeTime += Time.deltaTime;
            timeText.text = "Time : " + (int)survibeTime;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    public void EndGame()
    {
        isGameover = true;
        Reset.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");

        if(survibeTime > bestTime)
        {
            bestTime = survibeTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        recordText.text = "Best Time : " + (int)bestTime;


    }


}
