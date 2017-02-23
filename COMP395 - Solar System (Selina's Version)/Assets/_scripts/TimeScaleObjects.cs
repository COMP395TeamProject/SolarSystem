using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeScaleObjects : MonoBehaviour
{
	//Public Instances
	public string inputTimeScale;
	public float timeScaleFloat;
	public Text Username_field;
    public Text timeScaleText;

	//
	public void OnEdit()
	{
		//Gets value from txtTimeScale
		inputTimeScale = Username_field.text.ToString();

		//Converts string to float
		timeScaleFloat = float.Parse(inputTimeScale);

		//set timescale to user input
		Time.timeScale = timeScaleFloat;
	}

    public void Start()
    {
        timeScaleText.text = "TimeScale: 1";
    }

    public void ChangeTimeScale(float value)
    {
        Time.timeScale = value;
        timeScaleText.text = "TimeScale: " + value;
    }
}