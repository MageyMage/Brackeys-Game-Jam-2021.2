using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
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

            GameObject[] windowArray = GameObject.FindGameObjectsWithTag("window");
            foreach(GameObject window in windowArray)
            {
                Destroy(window);
            }
            
        }

        if(current <= 0)
        {
            VictoryEndSceen.SetActive(true);
        }
    }
    
    public void DecreaseFill()
    {
        current -= 6;
    }

    public void DecreaseFillMore()
    {
        current -= 25;
    }

}
