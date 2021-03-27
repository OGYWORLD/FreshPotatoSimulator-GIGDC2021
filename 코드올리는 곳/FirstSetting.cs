using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstSetting : MonoBehaviour
{
	ButtonManager bm;

	// 입력받는 주인공 설정
	private string ys_mainName;
	private string ys_mainAge;
	private string ys_mainDepartment;
	private string ys_mainSex;

	// input field & button
	TextMeshProUGUI named;
	TextMeshProUGUI age;
	TextMeshProUGUI department;
	Toggle man;
	Button start;

	private void Awake()
	{
		bm = GameObject.Find("Main Camera").GetComponent<ButtonManager>();

		string path = "BigCanvas/FirstSettingCanvas/";
		named = GameObject.Find(path + "Name/Input/TextArea/Text").GetComponent<TextMeshProUGUI>();
		age = GameObject.Find(path + "Age/Input/TextArea/Text").GetComponent<TextMeshProUGUI>();
		department = GameObject.Find(path + "Department/Input/TextArea/Text").GetComponent<TextMeshProUGUI>();
		man = GameObject.Find(path + "Sex/Man").GetComponent<Toggle>();
		start = GameObject.Find(path + "StartButton").GetComponent<Button>();
		start.onClick.AddListener(OnButtonStart);

		Debug.Log("input field 컴포넌트 가져오기");
	}

	// 입력받은 나이가 적합한지 확인
	private bool CheckAge(string a)
	{
		// 숫자, 두자리수
		string ag = "";

		// 숫자만 걸러냄
		foreach(char c in a)
		{
			if(c >= 0x30 && c <= 0x39)
			{
				ag += c;
			}
		}

		// 숫자 길이 확인
		if(ag.Length != 2)
		{
			return false;
		}
		return true;
	}

	// 입력받은 학과가 적합한지 확인
	private bool CheckDepartment(string d)
	{
		// 한글, 3자부터 15자까지
		string dep = "";

		// 상용 한글만 걸러냄
		foreach(char c in d)
		{
			if(c >= 0xAC00 && c <= 0xD7AF)
			{
				dep += c;
			}
		}

		// 문자열 길이 확인
		if(dep.Length >= 3 && dep.Length <= 15)
		{
			return true;
		}
		return false;
	}

	// 입력받은 이름이 적합한지 확인
	private bool CheckName(string n)
	{
		// 한글, 2자부터 10자까지
		string named = "";

		// 상용 한글만 걸러냄
		foreach(char c in n)
		{
			if(c >= 0xAC00 && c <= 0xD7AF)
			{
				named += c;
			}
		}

		// 문자열 길이 확인
		if(named.Length >= 2 && named.Length <= 10)
		{
			return true;
		}
		return false;
	}

	// 시작 버튼이 눌렸을 때
	private void OnButtonStart()
	{
		// man에 체크되어있다면
		if(man.isOn)
		{
			ys_mainSex = "남자";
		}
		else
		{
			ys_mainSex = "여자";
		}

		// 입력받은 정보들 확인
		if(CheckAge(age.text) && CheckDepartment(department.text) && CheckName(named.text))
		{
			ys_mainName = named.text;
			ys_mainAge = age.text;
			ys_mainDepartment = department.text;

			Debug.Log("이름: " + ys_mainName + "\n나이: " + ys_mainAge + "\n학과: " + ys_mainDepartment + "\n성별: " + ys_mainSex);
			
			Debug.Log("다음 씬");

			//string file = "Resource/save.txt";

			FileStream f = new FileStream(Application.persistentDataPath + "save.txt", FileMode.Create);
			StreamWriter writer = new StreamWriter(f);

			writer.WriteLine(ys_mainName);
			writer.WriteLine(ys_mainAge);
			writer.WriteLine(ys_mainDepartment);
			writer.WriteLine(ys_mainSex);

			bm.onNext();
		}
		else
		{
			Debug.Log("뭔가 이상해!!!");
		}
	}
}