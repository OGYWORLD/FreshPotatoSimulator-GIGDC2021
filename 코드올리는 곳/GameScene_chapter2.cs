using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameScene_chapter2 : MonoBehaviour
{
	// 주인공 변수 저장
	string named = "주인공";
	string department = "컴퓨터공학과";
	bool meet_minji = false;
	bool go_ot = false;
	bool go_mt = false;
	// 대화 표시 숫자 (시드(4), 챕터(1), 대화(3))
	private uint count = 202110000;

	// 대화창
	Button dialogue;
	TextMeshProUGUI dialogueText;

	// 캐릭터 이미지
	Sprite MA;          // 김영준
	Sprite MB;          // 이기훈
	Sprite MC;          // 한지우
	Sprite WA_smile;    // 이민지 미소
	Sprite WA_frown;    // 이민지 찡그림
	Sprite WB_smile;    // 유하경 미소
	Sprite WB_frown;    // 유하경 찡그림
	Sprite WC_smile;    // 최윤 미소
	Sprite WC_laugh;    // 최윤 웃음

	// 선택지창
	GameObject panel;
	Button c1;
	TextMeshProUGUI c1Text;
	Button c2;
	TextMeshProUGUI c2Text;
	Button c3;
	TextMeshProUGUI c3Text;


	public void Start()
	{
		dialogue = GameObject.Find("Canvas/DialogueButton/").GetComponent<Button>();
		dialogue.onClick.AddListener(click_0);
		dialogueText = GameObject.Find("Canvas/DialogueButton/Text/").GetComponent<TextMeshProUGUI>();

		MA = GameObject.Find("Charactor/Man_A/").GetComponent<Sprite>();
		MB = GameObject.Find("Charactor/Man_B/").GetComponent<Sprite>();
		MC = GameObject.Find("Charactor/Man_C/").GetComponent<Sprite>();
		WA_smile = GameObject.Find("Charactor/Woman_A_smile/").GetComponent<Sprite>();
		WA_frown = GameObject.Find("Charactor/Woman_A_frown/").GetComponent<Sprite>();
		WB_smile = GameObject.Find("Charactor/Woman_B_smile/").GetComponent<Sprite>();
		WB_frown = GameObject.Find("Charactor/Woman_B_frown/").GetComponent<Sprite>();
		WC_smile = GameObject.Find("Charactor/Woman_C_smile/").GetComponent<Sprite>();
		WC_laugh = GameObject.Find("Charactor/Woman_C_laugh/").GetComponent<Sprite>();

		panel = GameObject.Find("Canvas/Panel/").gameObject;
		c1 = GameObject.Find("Canvas/Panel/ChoiceButton1/").GetComponent<Button>();
		c1.onClick.AddListener(click_0);
		c1Text = GameObject.Find("Canvas/Panel/ChoiceButton1/Text/").GetComponent<TextMeshProUGUI>();
		c2 = GameObject.Find("Canvas/Panel/ChoiceButton2/").GetComponent<Button>();
		c2Text = GameObject.Find("Canvas/Panel/ChoiceButton2/Text/").GetComponent<TextMeshProUGUI>();
		c3 = GameObject.Find("Canvas/Panel/ChoiceButton3/").GetComponent<Button>();
		c3Text = GameObject.Find("Canvas/Panel/ChoiceButton3/Text/").GetComponent<TextMeshProUGUI>();

		panel.SetActive(false);
		//count = 20214000;   // test
		go_ot = true;  // test
	}

	public void clear()
	{
		dialogueText.text = "";
		panel.SetActive(false);
		c1Text.text = "";
		c1.gameObject.SetActive(false);
		c2Text.text = "";
		c2.gameObject.SetActive(false);
		c2.onClick.RemoveAllListeners();
		c3Text.text = "";
		c3.gameObject.SetActive(false);
		c3.onClick.RemoveAllListeners();
	}

	// 기본 대화, 선택지 1
	private void click_0()
	{
		count++;
	}

	// 선택지 1-2
	private void click_1_2()
	{
		count = 202111044;
	}

	// 선택지 2-2
	#region
	private void click_2_2()
	{
		count = 202112015;
	}

	// 선택지 2-2-2
	private void click_2_2_2()
	{
		count = 202111009;
	}

	// 선택지 2-3
	private void click_2_3()
	{
		count = 202111013;
	}
	#endregion

	// 선택지 3-2
	private void click_3_2()
	{
		count = 202112015;
	}

	// 선택지 4-2
	private void click_4_2()
	{
		count = 20213041;
	}

	// 선택지 5-2
	#region
	private void click_5_2()
	{
		count = 20213013;
	}

	// 선택지 5-3
	private void click_5_3()
	{
		count = 20213020;
	}
	#endregion

	// 선택지 6-2
	private void click_6_2()
	{
		count = 20214004;
	}

	// 선택지 7-2
	private void click_7_2()
	{
		count = 20215055;
	}

	// 선택지 8-2
	private void click_8_2()
	{
		count = 20216033;

	}

	public void Update()
	{
		// 씬 1
		#region
		if (count == 2021110000)
		{
			clear();

			dialogueText.text = "<b><size=60>교수님</size></b>\n오늘 여기까지 할까요? 수고하셨습니다.";
		}
		else if (count == 2021110001)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(수업이 끝나고 핸드폰을 확인하자 학생회로부터 과 MT를 갈거냐는 설문조사 코코오톡이 와있었다.)";
		}
		else if (count == 2021110002)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n영준아, 너 MT 갈거야?";
		}
		else if (count == 2021110003)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n모르겠어.";
		}
		else if (count == 2021110004)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n앗 알겠어...";
		}
		else if (count == 2021110005)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(수업이 끝나고 강의실 밖으로 나왔다. 그런데 그 순간)";
		}
		else if (count == 2021110006)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n야 김영준!!!";
		}
		else if(count == 2021110007)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(저기 멀리서 기훈이가 영준이의 이름을 부르며 뛰어오고 있었다.)";
		}
		else if(count == 2021110008)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n어? " + named + "도 안녕~";
		}
		else if(count == 2021110009)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n안녕!";
		}
		else if(count == 2021110010)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n영준아 너 MT 갈거야? 갈 거지? 가자 응?";
		}
		else if(count == 2021110011)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n생각해볼게.";
		}
		else if(count == 2021110012)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n아 가자~ 너도 갈거지?";
		}
		else if(count == 2021110013)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n음 나도 더 생각해보려고!";
		}
		else if(count == 2021110014)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n야! 이기훈!";
		}
		else if(count == 2021110015)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(처음 보는 여자애가 기훈이의 어깨를 툭 쳤다.)";
		}
		else if(count == 2021110016)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n어? 너 왜 여깄냐. 윤이도 안녕~";
		}
		else if(count == 2021110017)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n안녕!!!!!";
		}
		else if(count == 2021110018)
		{
			if(!go_ot)
			{
				count = 2021110019;
			}
			else
			{
				count = 2021110034;
			}
		}
		else if(count == 2021110019)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(나는 아는 사람이 없어서 뻘쭘하다...)";
		}
		else if(count == 2021110020)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n" + named + " 인사해! 얘네도 우리과야!";
		}
		else if(count == 2021110021)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n안녕하세요~ 21학번 최윤이에요!";
		}
		else if(count == 2021110022)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n저도 21학번이고 유하경이에요!";
		}
		else if(count == 2021110023)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n네~ 안녕하세요. 21학번 " + named + "입니다!";
		}
		else if(count == 2021110024)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n너네 MT 갈거야? 가자 응?";
		}
		else if(count == 2021110025)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n무조건 가야지! 첫 MT인데!";
		}
		else if(count == 2021110026)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n난 빠른이라서 술집을 못가니까 MT까서 많이 마셔야지...";
		}
		else if(count == 2021110027)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n" + named + ", 너도 생각해보고 갈 거면 나한테도 알려줘!!";
		}
		else if(count == 2021110028)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n응! 알겠어.";
		}
		else if(count == 2021110029)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n영준아, 너도... 응?";
		}
		else if(count == 2021110030)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(영준이가 그새 사라져있다.)";
		}
		else if(count == 2021110031)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n아휴.. 얘는 맨날 사라진다니깐...";
		}
		else if(count == 2021110032)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(저기 멀리서 토익 영단어 책을 보고 있는 영준이가 보인다...)";
		}
		else if(count == 2021110034)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n" + named + ", 안녕~ 하경이 본 적 있지? 얘 그때 뒷풀이에서 쫓겨났던 애야!";
		}
		else if(count == 2021110035)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n야! 쫓겨났다니!! 맞는 말이긴 한데...";
		}
		else if(count == 2021110036)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n안녕하세요! 저는 " + named + "(이)에요.";
		}
		else if(count == 2021110037)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n저는 유하경입니다~";
		}
		else if(count == 2021110038)
		{
			count = 2021110024;
		}
		else if (count == 2021110033)
		{
			count = 2021111000;
		}
		// 카카오톡 투표 MT 간다/안간다.
		#endregion
		// 씬 2
		#region
		else if (count == 202111000)
		{
			clear();
			if(go_mt)
			{
				count = 2021110001;
			}
			else
			{
				count = 202114000;
			}
		}
		else if (count == 202111001)
		{
			dialogueText.text = "<b><size=60>학생회1</size></b>\n지금부터 저녁 먹을 건데요, 앉아계시면 저희가 고기 가져다 드릴게요!";
		}
		else if (count == 202111002)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n와! 고기 맛있겠다!";
		}
		else if (count == 202111003)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(다들 고기 먹을 생각에 신나있는 것 같다.)";
		}
		else if (count == 202111004)
		{
			dialogueText.text = "<b><size=60>학생회2</size></b>\n소주는 여기 있으니깐 가져다 드시면 됩니다!";
		}
		else if (count == 202111005)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n헐 소주! 내가 가져올게!!";
		}
		else if (count == 202111006)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(하경이는 많이 들떠보였다...)";
		}
		else if (count == 202111007)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n얘들아, 몇 병 가져가? 2병?";
		}
		else if (count == 202111008)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n적어도 3병 필요하지 않을까?";
		}
		else if (count == 202111009)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n알겠어!!!";
		}
		else if (count == 202111010)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(하경이가 힘겹게 4병을 들고 온다...)";
		}
		else if (count == 202111011)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n이 중 한 병은 내가 다 마신다??!! 다들 술 잔 채워~";
		}
		else if(count == 202111012)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n얘들아 잔 줘. 내가 따라줄게!";
		}
		else if(count == 202111013)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(영준이는 구석에 말 없이 앉아있다.)";
		}
		else if(count == 202111014)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n영준아 너도 술 마셔?";
		}
		else if(count == 202111015)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n아직 한 번도 안 마셔봤는데.";
		}
		else if(count == 202111016)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n야! 김영준 한 번도 술 안마셔봤대!! 영준이 먹이자!!!";
		}
		else if(count == 202111017)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n뭘 또 먹여~ 일단 건배하자!!";
		}
		else if(count == 202111018)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(다 같이 건배를 한다. 영준이는 궁금했는지 술을 마셨다. 곧 영준이의 얼굴이 빨개진다.)";
		}
		else if(count == 202111019)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n어? 영준이 얼굴 빨개졌다! 더 마셔!!";
		}
		else if(count == 202111020)
		{
			dialogueText.text = "<b><size=60>학생회3</size></b>\n고기 더 필요하면 말해요~";
		}
		else if(count == 202111021)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n감사합니다~ 얘들아! 고기 먹자!";
		}
		else if(count == 202111022)
		{
			dialogueText.text = "<b><size=60>학생회4</size></b>\n저희 이제 주루마블 할 건데요, 조 먼저 짤게요!";
		}
		else if(count == 202111023)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(한 명씩 나가서 상자 안에 있는 종이를 뽑았다. 나는 1조가 나왔다.)";
		}
		else if(count == 202111024)
		{
			dialogueText.text = "<b><size=60>학생회4</size></b>\n다들 번호 확인하셨으면 1조부터 모일게요!";
		}
		else if(count == 202111025)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n어! 뭐야. 이기훈 빼고 다 같은 조야?";
		}
		else if(count == 202111026)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n어쩐지 이기훈이 자기 조 확인하더니 다른 사람한테 계속 바꾸자고 그러고 있더라고...";
		}
		else if(count == 20111027)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n영준이도 1조네.";
		}
		else if(count == 202111028)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n맞아. 나도 1조야.";
		}
		else if(count == 202111029)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(아까 좀 취했는지 말수가 많아진 것 같다.)";
		}
		else if(count == 202111030)
		{
			dialogueText.text = "<b><size=60>학생회4</size></b>\n조 별로 다 모였으면 주루마블 시작할게요! 1조부터 주사위 굴려주세요!";
		}
		else if(count == 202111031)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n누가 돌려? 내가 돌려?";
		}
		else if(count == 202111032)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n내가 돌릴게!";
		}
		else if(count == 202111033)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(주사위를 던지고 말이 멈춘 곳은 '돌린 사람 종이컵으로 한 컵 or 돌린 사람 빼고 소주잔으로 두 잔'이 나왔다.)";
		}
		else if(count == 202111034)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n윽! 첫 판부터 의리게임이라니..";
		}
		else if(count == 202111035)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(어떻게 해야 할까?)";
			panel.SetActive(true);
			c1Text.text = "종이컵으로 한 컵 마신다.";					// -> 202111036
			c1.gameObject.SetActive(true);
			c2Text.text = "나 빼고 소주잔으로 두 잔씩 마시라고 한다.";	// -> 202111044
			c2.gameObject.SetActive(true);
			c2.onClick.AddListener(click_1_2);
		}
		else if(count == 202111036)
		{
			clear();
			bool love = false;
			if(!love)
			{
				count = 202111037;
			}
			else
			{
				count = 202111040;
			}
		}
		else if(count == 202111037)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n에잇!";
		}
		else if(count == 202111038)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(생각 없이 한 컵을 다 마셔버렸다. 눈 앞이 깜깜하다...)";
		}
		else if(count == 202111040)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n에잇!";
		}
		else if(count == 202111041)
		{
			dialogueText.text = "<b><size=60>호감도</size></b>\n이거 몰래 소주 대신 물 따른거야. 이거 마셔.";
		}
		else if(count == 202111042)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n어.. 고마워!";
		}
		else if(count == 202111044)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(나는 사악한 웃음을 지으며 알했다.)";
		}
		else if(count == 202111045)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n나 빼고 두 잔씩 마셔!";
		}
		else if(count == 202111046)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n내가 네 잔 마실까??? 나 잘 마실 수 있어!!!";
		}
		else if(count == 202111047)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n너 이미 많이 취했어! 하경아!!";
		}
		else if(count == 202111048)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(조원들은 나 빼고 두 잔씩 마셨다...)";
		}
		// 다음 씬으로
		else if (count == 202111039 | count == 202111043 | count == 202111049)
		{
			count = 202112000;
		}
		#endregion
		// 씬 3
		#region
		else if (count == 202112000)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(주루마블이 끝나고 난 뒤, 다들 힘들어보인다...)";
		}
		else if (count == 202112001)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n아~ 화장시일... (딸꾹) 누가 이써어~? 나 너무 어지러어... 우욱..!";
		}
		else if (count == 202112002)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n나 잡아봐!! 하하하하! 나 잡아봐!! 얏호!";
		}
		else if (count == 202112003)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n하경아 어디가!!";
		}
		else if (count == 202112004)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(다들 정신없어 보인다... 저기 구석에서 영준이가 거울을 보며 중얼거리는 모습이 보인다.)";
		}
		else if (count == 202112005)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n안녕? 너 어디서 본 거 같다. 아닌가?...";
		}
		else if (count == 202112006)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n쟤도 취하는구나...";
		}
		else if (count == 202112007)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(나도 이불이 펴져 있는 곳 아무데나 누워서 잠에 들었다.)";
		}
		else if (count == 202112008)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n아 머리아파...";
		}
		else if (count == 202112009)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(아픈 머리와 함께 비몽사몽 잠에서 깼다.)";
		}
		else if (count == 202112010)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(일어나보니 학생회 선배들이 뒷정리를 하고 있었다.)";
		}
		else if (count == 202112011)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(도와줘야할까?)";
			panel.SetActive(true);
			c1Text.text = "그냥 다시 자는 척한다.";	// -> 202112012
			c1.gameObject.SetActive(true);
			c2Text.text = "일어나서 도와준다.";		// -> 202112015
			c2.gameObject.SetActive(true);
			c2.onClick.AddListener(click_2_2);
		}
		else if (count == 202112012)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(아 아직 술도 안깼는데... 그냥 더 자야지...)";
		}
		else if (count == 202112013)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(나는 곧 다시 잠에 들었다.)";
		}
		// 씬 3 선택지 2-2
		else if (count == 202112015)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(선배들도 힘들텐데 도와줘야지...)";
		}
		else if (count == 202112016)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n뭐 좀 도와드릴까요?";
		}
		else if(count == 202112017)
		{
			dialogueText.text = "<b><size=60>학생회1</size></b>\n쉬고 계셔도 돼요! 저희가 치울게요!";
		}
		else if(count == 202112018)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(가만히 있고 싶었지만 하경이는 이미 일어나서 쓰레기를 줍고 있었다.)";
		}
		else if(count == 202112019)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n일찍 일어났네!";
		}
		else if(count == 202112020)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n나도 같이 청소할게!";
		}
		// 다음 씬
		else if (count == 202112014 | count == 202112021)
		{
			count = 202113000;
		}
		#endregion
		// 씬 4
		#region
		else if (count == 202113000)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(우리는 다 같이 짐을 싸고 지하철역으로 나왔다.)";
		}
		else if (count == 202113001)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n아~ 죽을 것 같아~";
		}
		else if (count == 202113002)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(기훈이는 앚기 중심을 못잡는 듯 하다...)";
		}
		else if (count == 202113003)
		{
			dialogueText.text = "<b><size=60>학생회1</size></b>\n저희 다 같이 단체사진 찍고 갈게요! 모여주세요!";
		}
		else if (count == 202113004)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(학생회의 지시에 따라 다 같이 사진을 찍고 지하철역으로 향했다.)";
		}
		// 다음 씬
		else if (count == 202113005)
		{
			count = 202114000;
		}
		#endregion
		else
		{
			Application.Quit();
		}
	}
}