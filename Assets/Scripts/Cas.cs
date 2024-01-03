using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cas : MonoBehaviour
{
    float currentTime;
    public float startingTime = 60f;

    [SerializeField]  TextMesh countdownText;
    void Start()
    {
        currentTime = startingTime;
    }
    void FixedUpdate()
    {

        currentTime += -1 * Time.deltaTime;
        countdownText.text = Mathf.Round (currentTime) +"";

        if (currentTime <= 10)
        {
            countdownText.color = Color.red;
        }

        if(currentTime <= 0){
        
        }
    }

}