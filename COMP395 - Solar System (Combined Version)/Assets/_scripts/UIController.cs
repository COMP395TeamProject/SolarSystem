using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour 
{

	//Public Instances
	//NOTE: These instances refers to the "txt" counterpart compoenents due to me adding the button component on the "txt"s
	public Button btnBegin;
	public Button btnOverview;
	public Button btnMenu;
	public Button btnExit;
	public Button btnReset;

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
		SceneManager.LoadScene ("SimulationScene");
	}

//	//Change scene to "OverviewScene"
//	public void ChangeToOverviewScene()
//	{
//		SceneManager.LoadScene ("OverviewScene");
//	}

	//Change scene to "MenuScene"
	public void BackToMenuScene()
	{
		SceneManager.LoadScene ("MenuScene");
	}

	//Quites Game
	public void Reset()
	{
		SceneManager.LoadScene ("SimulationScene");
	}

	//Quites Game
	public void Exit()
	{
		Application.Quit();
	}
}
