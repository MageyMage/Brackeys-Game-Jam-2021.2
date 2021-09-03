using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{

    public int maximum;
    public int current = 1;
    public GameObject FailedEndScreen;
    public GameObject VictoryEndSceen;
    public Image mask;
    float lastUpdate;

    void Update()
    {
        if(Time.time - lastUpdate >= 1f)
        {
            GetCurrentFill();
            lastUpdate = Time.time;
        }
    }

    void GetCurrentFill()
    {
        current += 10;
        float fillAmount = (float)current / (float)maximum;
        mask.fillAmount = fillAmount;

        if(current >= maximum)
        {
            FailedEndScreen.SetActive(true);
            FailedEndScreen.transform.SetAsLastSibling();

        }

        if(current <= 0)
        {
            VictoryEndSceen.SetActive(true);
            VictoryEndSceen.transform.SetAsLastSibling();
        }

    }
    
    public void DecreaseFill(int decreaseAmount)
    {
        current -= decreaseAmount; // make sure your inputting a non negative number so it goes down
    }
    

}
