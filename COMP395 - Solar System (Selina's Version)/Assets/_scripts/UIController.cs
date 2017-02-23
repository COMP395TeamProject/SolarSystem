using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour 
{

	//Public Instances
	//NOTE: These instances refers to the "txt" counterpart compoenents due to me adding the button component on the "txt"s
	public Button btnBegin;
	public Button btnOverview;
	public Button btnMenu;
	public Button btnExit;

	//Initialization
	public void Start()
	{
		//Initializing instance varaibles to corresponding components
		//		btnBegin = btnBegin.GetComponent<Button>();
		//		btnInfo = btnInfo.GetComponent<Button>();
		//		btnExit = btnExit.GetComponent<Button>();
	}

	//Public Methods
	//begins simulation by changing to "SimulationScene"
	public void BeginSimulation()
	{
		Application.LoadLevel ("SimulationScene");
	}

	//Change scene to "OverviewScene"
	public void ChangeToOverviewScene()
	{
		Application.LoadLevel ("OverviewScene");
	}

	//Change scene to "OverviewScene"
	public void BackToMenuScene()
	{
		Application.LoadLevel ("MenuScene");
	}

	//Quites Game
	public void Exit()
	{
		Application.Quit();
	}
}
