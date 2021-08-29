using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{

    public Slider MathSlider;
    public GameObject MathQuestion;
    public GameObject ProgressBar;
    public RectTransform mathTransform;
    public GameObject NextMathQuestion;
    public int CorrectAnswer;

    public void OnClick_()
    {
        if(MathSlider.value == CorrectAnswer)
        {
            MathQuestion.SetActive(false);
            ProgressBar.GetComponent<ProgressBar>().DecreaseFillMore();
            mathTransform.SetAsLastSibling();
            NextMathQuestion.SetActive(true);
        }
    }

}
