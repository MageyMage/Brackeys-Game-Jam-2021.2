using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{

    public Slider MathSlider;
    public RectTransform mathTransform;
    public int CorrectAnswer;

    public void OnClick_()
    {
        if(MathSlider.value == CorrectAnswer)
        {
            GameObject ProgressBar = GameObject.Find("ProgressBar");
            ProgressBar.GetComponent<ProgressBar>().DecreaseFillMore();
            mathTransform.SetAsLastSibling();
        }
    }

}
