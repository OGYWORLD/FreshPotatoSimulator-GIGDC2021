using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
	ButtonManager bm;

    Button newB;
	Button continueB;
	Button exitB;

	public void Start()
	{
		bm = GameObject.Find("Main Camera").GetComponent<ButtonManager>();

		newB = GameObject.Find("NewButton").GetComponent<Button>();
		continueB = GameObject.Find("ContinueButton").GetComponent<Button>();
		exitB = GameObject.Find("ExitButton").GetComponent<Button>();

		newB.onClick.AddListener(bm.onNext);
		continueB.onClick.AddListener(bm.onContinue);
		exitB.onClick.AddListener(bm.onExit);

		Debug.Log("시작 화면");
	}
}