using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameScene_chapter1 : MonoBehaviour
{
	// 주인공 변수 저장
	string named = "주인공";
	string department = "컴퓨터공학과";
	bool meet_minji = false;
	bool go_ot = false;
	// 대화 표시 숫자 (시드(4), 챕터(1), 대화(3))
	private uint count = 20210000;

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
		count = 20214000;   // test
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
		count = 20210006;
	}

	// 선택지 2-2
	#region
	private void click_2_2()
	{
		count = 20211005;
	}

	// 선택지 2-2-2
	private void click_2_2_2()
	{
		count = 20211009;
	}

	// 선택지 2-3
	private void click_2_3()
	{
		count = 20211013;
	}
	#endregion

	// 선택지 3-2
	private void click_3_2()
	{
		count = 20212015;
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
		if (count == 20210000)
		{
			clear();

			dialogueText.text = "<b><size=60>" + named + "</size></b>\n우와~ 여기가 내가 다닐 학교라니! 여기 대강당이 어디지?";
		}
		else if (count == 20210001)
		{
			dialogueText.text = "(강당이 어딘지 모르겠다! 어떻게 할까?)";
			panel.SetActive(true);
			c1Text.text = "지나가는 사람에게 물어본다.";    // -> 20210002
			c1.gameObject.SetActive(true);
			c2Text.text = "핸드폰으로 지도를 찾아본다.";    // -> 20210005
			c2.gameObject.SetActive(true);
			c2.onClick.AddListener(click_1_2);


			Debug.Log("선택지 1");
		}
		// 씬 1 선택지 1-1
		else if (count == 20210002)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n혹시 죄송한데 입학식 어디서 해요?";
		}
		else if (count == 20210003)
		{
			dialogueText.text = "<b><size=60>한지우</size></b>\n아 저기 보이는 하얀색 큰 건물로 가시면 돼요!";
		}
		else if (count == 20210004)
		{
			//charactor.gameObject.SetActive(true);
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n감사합니다~";
		}
		// 씬 1 선택지 1-2
		else if (count == 20210006)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n그렇지, 인생은 혼자야..!";
		}
		else if (count == 20210007)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n아 저기 위로 가면 되겠구나!";
		}
		// 다음 씬으로
		else if (count == 20210005 | count == 20210008)
		{
			count = 20211000;
		}
		#endregion
		// 씬 2
		#region
		else if (count == 20211000)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n" + department + "는 2층이구나. 여기 앉아야겠다.";
		}
		else if (count == 20211001)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(입학식이 시작된다. 간단한 학교 설명 후 총장님의 훈화말씀이 시작된다.)";
		}
		else if (count == 20211002)
		{
			dialogueText.text = "(듣다보니 눈이 슬슬 감긴다. 어떻게 해야 할까?)";
			panel.SetActive(true);
			c1Text.text = "그대로 조용히 잔다.";        // -> 20211003
			c1.gameObject.SetActive(true);
			c2Text.text = "옆 사람에게 말을 걸어본다.";    // -> 20211005
			c2.gameObject.SetActive(true);
			c2.onClick.AddListener(click_2_2);
			c3Text.text = "허벅지를 때려서 잠을 깬다.";    // -> 20211010
			c3.gameObject.SetActive(true);
			c3.onClick.AddListener(click_2_3);

			Debug.Log("선택지 2");
		}
		// 씬 2 선택지 2-1
		else if (count == 20211003)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(Zzzzzzzz....)";
		}
		// 씬 2 선택지 2-2
		else if (count == 20211005)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(뭐라고 인사하지?)";
			panel.SetActive(true);
			c1Text.text = "저기... 안녕? 많이 졸리지 않니?";       // -> 20211006
			c1.gameObject.SetActive(true);
			c2Text.text = "안녕하세요... 입학식이 많이 졸리네요."; // -> 20211009
			c2.gameObject.SetActive(true);
			c2.onClick.AddListener(click_2_2_2);
		}
		// 씬 2 선택지 2-2-1
		else if (count == 20211006)
		{
			clear();
			dialogueText.text = "<b><size=60>이민지</size></b>\n아 네...";
		}
		else if (count == 20211007)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(그 이후로 대화는 이어지지 않았다.)";
		}
		// 씬 2 선택지 2-2-2
		else if (count == 20211009)
		{
			clear();
			meet_minji = true;
			dialogueText.text = "<b><size=60>이민지</size></b>\n그러게요... 정말 졸리네요... 혹시 " + department + "세요?";
		}
		else if (count == 20211010)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n네! " + department + "에요!";
		}
		else if (count == 20211011)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(대화를 하다 보니 서로 많이 친해졌다. 어느새 입학식이 끝나버렸다.)";
		}
		// 씬 2 선택지 2-3
		else if (count == 20211013)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n아니야 자면 안돼! 총장님이 밤 새시면서 말씀을 준비해 오셨을텐데...";
		}
		else if (count == 20211014)
		{
			dialogueText.text = "<b><size=60>교수님</size></b>\n(교수님도 졸려서 주위를 둘러보다가 " + named + "를 발견한다. 끝내 흐뭇한 미소를 지으신다.)";
		}
		// 다음 씬으로
		else if (count == 20211004 | count == 20211008 | count == 20211012 | count == 20211015)
		{
			count = 20212000;
		}
		#endregion
		// 씬 3
		#region
		else if (count == 20212000)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(주변이 어수선하다... 이제 뭘 해야하지?)";
		}
		else if (count == 20212001)
		{
			dialogueText.text = "<b><size=60>학생회</size></b>\n" + department + " 신입생분들은 모여서 과 오리엔테이션 진행할게요~";
		}
		else if (count == 20212002)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n이제 말로만 듣던 OT를 가나보다..!";
			panel.SetActive(true);
			c1Text.text = "오티를 간다";	// -> 20212003
			c1.gameObject.SetActive(true);
			c2Text.text = "오티를 안간다.";	// -> 20212015
			c2.gameObject.SetActive(true);
			c2.onClick.AddListener(click_3_2);
		}
		// 씬 3 선택지 3-1
		else if (count == 20212003)
		{
			clear();
			go_ot = true;
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(여기 앉아있으면 되겠지? 뭐하는걸까?)";
		}
		else if (count == 20212004)
		{
			dialogueText.text = "<b><size=60>단과대 학생회</size></b>\n(우루루 앞으로 나온다.) 안녕하세요~ " + department + " 단과대 학생회입니다.";
		}
		else if (count == 20212005)
		{
			dialogueText.text = "<b><size=60>단과대 학생회</size></b>\n기획부 부장입니다~ 기획부 차장입니다~";
		}
		else if (count == 20212006)
		{
			dialogueText.text = "<b><size=60>단과대 학생회</size></b>\n홍보부 부장입니다~ 홍보부 차장입니다~ ...";
		}
		else if (count == 20212007)
		{
			dialogueText.text = "<b><size=60>단과대 학생회</size></b>\n이상 " + department + " 단과대 학생회였습니다.";
		}
		else if (count == 20212008)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(... 와 진짜 많다... 이제 끝인가?)";
		}
		else if (count == 20212009)
		{
			dialogueText.text = "<b><size=60>과 학생회</size></b>\n(우루루 앞으로 나온다.) 안녕하세요~ " + department + " 학생회입니다.";
		}
		else if (count == 20212010)
		{
			dialogueText.text = "<b><size=60>과 학생회</size></b>\n영상부 부장입니다~ 영상부 차장입니다~ ...";
		}
		else if (count == 20212011)
		{
			dialogueText.text = "<b><size=60>과 학생회</size></b>\n이상 " + department + " 학생회였습니다.";
		}
		else if (count == 20212012)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(후.. 드디어 끝났나보네. 이제 뭐하는거지? 집 가야하나?)";
		}
		else if (count == 20212013)
		{
			dialogueText.text = "<b><size=60>학생회</size></b>\n이제 뒤풀이 진행할거니까 미리미리 신분증 준비해주세요~";
		}
		// 씬 3 선택지 3-2
		else if (count == 20212015)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n오티 안 간다고 친구 안 생기는건 아니니깐~ 잠이나 자야지~";
		}
		else if (count == 20212016)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(잠을 잔다...)";
		}
		// 다음 씬
		else if (count == 20212017)
		{
			count = 20214000; // 오티 안가고 긱사 들어갔을 때
		}
		// 다음 씬 -> 뒤풀이
		else if (count == 20212014)
		{
			count = 20213000;
		}
		#endregion
		// 씬 4
		#region
		else if (count == 20213000)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(어디에 앉을까? 아무데나 앉을까?)";
			panel.SetActive(true);
			c1Text.text = "아무데나 앉는다.";              // -> 20213001
			c1.gameObject.SetActive(true);
			if (meet_minji)
			{
				c2Text.text = "친해진 동기 옆에 앉는다."; // -> 20213041
				c2.gameObject.SetActive(true);
				c2.onClick.AddListener(click_4_2);
			}
		}
		// 씬 4 선택지 4-1
		else if (count == 20213001)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(아.. 저기 빈자리 있는데 앉아야겠다.)";
		}
		else if (count == 20213002)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(빈자리에 앉는다.)";
		}
		else if (count == 20213003)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(너무 어색하다... 어떻게 하지?)";
			panel.SetActive(true);
			c1Text.text = "다른 사람이 얘기할 때 까지 기다린다.";  // -> 20213004
			c1.gameObject.SetActive(true);
			c2Text.text = "먼저 술게임을 하자고 제안한다.";          // -> 20213013
			c2.gameObject.SetActive(true);
			c2.onClick.AddListener(click_5_2);
			c3Text.text = "어색한 분위기를 없애기 위해 소주 반 병을 마셔버린다."; // -> 20213020
			c3.gameObject.SetActive(true);
			c3.onClick.AddListener(click_5_3);
		}
		else if (count == 20213004)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(그냥 가만히 있어야겠다...)";
		}
		else if (count == 20213005)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n저희... 술게임 할까요?! 하경이가 좋아하는 랜더엄...";
		}
		else if (count == 20213006)
		{
			dialogueText.text = "<b><size=60>직원</size></b>\n신분증 검사할세요.";
		}
		else if (count == 20213007)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n어! 혹시 빠른은 안되나요? 대학생인데...";
		}
		else if (count == 20213008)
		{
			dialogueText.text = "<b><size=60>직원</size></b>\n안됩니다.";
		}
		else if (count == 20213009)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n(시무룩...) 저... 집에 가볼게요... 다들 개강하고 봬요...";
		}
		else if (count == 20213010)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n술게임 마저 해요! 기훈이가 좋아하는 랜덤 게임~ 무슨 게임~ 게임 스타트!";
		}
		else if (count == 20213011)
		{
			dialogueText.text = "<b><size=60></size></b>\n(시간이 흐르고...)";
		}
		// 씬 4 선택지 5-2
		else if (count == 20213013)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n저희..  술게임 할까요?! " + named + "이/가 좋아하는 랜더엄...";
		}
		else if (count == 20213014)
		{
			dialogueText.text = "<b><size=60>직원</size></b>\n신분증 검사할세요.";
		}
		else if (count == 20213015)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n어! 혹시 빠른은 안되나요? 대학생인데...";
		}
		else if (count == 20213016)
		{
			dialogueText.text = "<b><size=60>직원</size></b>\n안됩니다.";
		}
		else if (count == 20213017)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n(시무룩...) 저... 집에 가볼게요... 다들 개강하고 봬요...";
		}
		else if (count == 20213018)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n술게임 마저 해요! 기훈이가 좋아하는 랜덤 게임~ 무슨 게임~ 게임 스타트!";
		}
		// 씬 4 선택지 5-3
		else if (count == 20213020)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(아 모르겠다... 먼저 술을 마셔버리자...)";
		}
		else if (count == 20213021)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n와! 멋있어요!!\n<color=#991010>(절대 멋있는게 아닙니다. 위험합니다.)</color>";
		}
		else if (count == 20213022)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(딸꾹) 저희.. 술게임 할까요?! " + named + "이/가 좋아하는 랜더엄...";
		}
		else if (count == 20213023)
		{
			dialogueText.text = "<b><size=60>직원</size></b>\n신분증 검사할세요.";
		}
		else if (count == 20213024)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n어! 혹시 빠른은 안되나요? 대학생인데...";
		}
		else if (count == 20213025)
		{
			dialogueText.text = "<b><size=60>직원</size></b>\n안됩니다.";
		}
		else if (count == 20213026)
		{
			dialogueText.text = "<b><size=60>유하경</size></b>\n(시무룩...) 저... 집에 가볼게요... 다들 개강하고 봬요...";
		}
		else if (count == 20213027)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n술게임 마저 해요! 기훈이가 좋아하는 랜덤 게임~ 무슨 게임~ 게임 스타트!";
		}
		// 씬 4 선택지 4-2
		else if (count == 20213041)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n어! 저기 민지언니다! 저기 가서 앉아야지.";
		}
		else if (count == 20213042)
		{
			dialogueText.text = "<b><size=60>이민지</size></b>\n(나를 발견하고 자신이 있는 곳으로 오라는 손짓을 한다.)";
		}
		else if (count == 20213043)
		{
			dialogueText.text = "<b><size=60>이민지</size></b>\n(의자를 탁탁 치며) 여기 와서 앉아!";
		}
		else if (count == 20213044)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(서로 대화를 하다 보니 어느덧 시간이 지났다.)";
		}
		else if (count == 20213045)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n안녕하세요~ 저희랑 같이 술게임 하실래요?";
		}
		else if (count == 20213046)
		{
			dialogueText.text = "<b><size=60>이민지</size></b>\n저는 늦어서 집에 가 봐야할 것 같아요! 재미있게 노세요.";
		}
		else if (count == 20213047)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n언니 잘가~ 다음에 보자!!";
		}
		else if (count == 20213048)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n오! 술게임 하러 오셨구나!! 그럼 시작할게요!! 기훈이가 좋아하는 랜덤 게임~ 무슨 게임~ 게임 스타트!!";
		}
		else if (count == 20213049)
		{
			dialogueText.text = "<b><size=60></size></b>\n(시간이 지난 후...)";
		}
		// 술 마시고 난 후
		else if (count == 20213012 | count == 20213019 | count == 20213028 | count == 20213050)
		{
			count = 20213029;
		}
		else if (count == 20213029)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n아~ 기분 조오타~!";
		}
		else if (count == 20213030)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n" + named + "! 번호... 바꾸자아~ 우리이~";
		}
		else if (count == 20213031)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n번호 교환 하자고? 조아! 핸드폰 죠바..";
		}
		else if (count == 20213032)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n저랑도 번호 교환해요! 우리 동갑이면 말 놓을까요? 저는 20살이에요~~!!";
		}
		else if (count == 20213033)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n저도 20살이에요! 이제부터 말 놓아요! 시이작!!";
		}
		else if (count == 20213034)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n좋아좋아!! 얘는 김영준이고 우리랑 동갑이야!!";
		}
		else if (count == 20213035)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n안녕하세요.";
		}
		else if (count == 20213036)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n아~ 화장실~ (딸꾹) 누가 데려가조.. 토할것.. 같... 우욱!";
		}
		else if (count == 20213037)
		{
			dialogueText.text = "<b><size=60>학생회1</size></b>\n괜찮아요? 걸을 수 있겠어요?";
		}
		else if (count == 20213038)
		{
			dialogueText.text = "<b><size=60>학생회2</size></b>\n이제 곧 통금이라서 기숙사생들은 들어가보셔야 합니다!!!!";
		}
		else if (count == 20213039)
		{
			dialogueText.text = "<b><size=60>최윤</size></b>\n" + named + ", 너 기숙사지? 나랑 영준이도 기숙사야! 같이가자!!";
		}
		// 다음 씬
		else if (count == 20213040)
		{
			count = 20214000;
		}
		#endregion
		// 씬 5
		#region
		else if (count == 20214000)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n드디어 개강이야! 저기 동아리 홍보 부스인가? 한 번 가볼까? 아.. 나 수업있지...";
		}
		else if (count == 20214001)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(어떻게 할까?)";
			panel.SetActive(true);
			c1Text.text = "수업을 들으러 간다.";            // -> 20214002
			c1.gameObject.SetActive(true);
			c2Text.text = "동아리 홍보 부스를 구경간다.";   // -> 20214004
			c2.gameObject.SetActive(true);
			c2.onClick.AddListener(click_6_2);
		}
		// 씬 5 선택지 6-1
		else if(count == 20214002)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n아니야! 대학교 생활 첫 날인데 수업을 빼먹을 순 없지!";
		}
		// 씬 5 선택지 6-2 -> 다음 씬
		else if(count == 20214004)
		{
			clear();
			count = 20216000;
		}
		// 다음 씬 -> 강의실
		else if(count == 20214003)
		{
			count = 20215000;
		}
		#endregion
		// 씬 6
		#region
		else if (count == 20215000)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n고등학교 교실이랑은 다른 것 같네... 아무데나 앉아도 되겠지?";
		}
		else if(count == 20215001)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n뭐야! 의자랑 책상이 붙어있잖아! 이거 너무 불편하다ㅠㅠ";
		}
		else if(count == 20215002)
		{
			if(go_ot)   // OT를 갔을 시
			{
				count = 20215003;
			}
			else
			{
				count = 20215011;
			}
		}
		else if(count == 20215003)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n옆 자리 사람은 벌써부터 공부하네. 아직 아는 것도 없는데...";
		}
		else if(count == 20215004)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n어? 영준이잖아?";
		}
		else if(count == 20215005)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n영... 영준아 안녕?";
		}
		else if(count == 20215006)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n안녕.";
		}
		else if(count == 20215007)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n아... 아 그래... 무슨 공부해?";
		}
		else if(count == 20215008)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n토익공부 해.";
		}
		else if(count == 20215009)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n오... 그래 열심히 해..";
		}
		else if(count == 20215011)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n아니 옆 자리 사람은 벌써부터 공부하네. 아직 아는 것도 없는데...";
		}
		else if(count == 20215012)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n저런 사람이 과탑을 하는 건가?";
		}
		else if(count == 20215013)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(책상을 정리하다가 지우개가 날아간다.)";
		}
		else if(count == 20215014)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n어? 지우개가 어디 갔지?";
		}
		else if(count == 20215015)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(무심코 옆자리를 봤는데 옆자리 사람 책 위에 지우애가 올라가있다...)";
		}
		else if(count == 20215016)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n어! 죄송해요ㅠㅠ";
		}
		else if(count == 20215017)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n괜찮습니다.";
		}
		else if(count == 20215018)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n혹시 " + department + "세요?";
		}
		else if(count == 20215019)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n네.";
		}
		else if(count == 20215020)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n와 저도 " + department + "에요. 저는 " + named + "(이)에요. 친하게 지내요!";
		}
		else if(count == 20215021)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n네. 저는 김영준이에요.";
		}
		else if(count == 20215022)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n저희 동갑인 것 같은데 말 놓는건 어때요?";
		}
		else if(count == 20215023)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n(당황한 모습을 보이며) 아 네...";
		}
		else if(count == 20215024)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n좋아!";
		}
		// 수업이 끝난 후
		else if(count == 20215010 | count == 20215025)
		{
			count = 20215026;
		}
		else if(count == 20215026)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n오티 한다고 몇 분 하지도 않았네...";
		}
		else if(count == 20215027)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n영준아. 동아리 홍보 부스 구경갈래?";
		}
		else if(count == 20215028)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n(당황한 모습을 보이며) 좋아.";
		}
		else if(count == 20215029)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n영준아, 너는 들어가고 싶은 동아리 있어?";
		}
		else if(count == 20215030)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n영어 회화 동아리 정도...?";
		}
		else if(count == 20215031)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n넌 정말 영어를 좋아하는구나.";
		}
		else if(count == 20215032)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n보드게임 동아리 블렌딩 들어오세요!!!!";
		}
		else if(count == 20215033)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n동아리들 신입생 쟁탈전이 어마어마하네...";
		}
		else if(count == 20215034)
		{
			if(!go_ot)
			{
				count = 20215035;
			}
			else
			{
				count = 20215045;
			}
		}
		else if(count == 20215035)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n어! 영준아!!";
		}
		else if(count == 20215036)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n어 안녕. 벌써 동아리 들어갔어?";
		}
		else if(count == 20215037)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n응~ 너도 들어올래? 옆에 있는 친구도 들어와요!";
		}
		else if(count == 20215038)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n저 분 우리과 선배셔?";
		}
		else if(count == 20215039)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n아니, 동기야. 동갑이고.";
		}
		else if(count == 20215040)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(많이 인싸구나.. 벌써 동아리도 들어가고...)";
		}
		else if(count == 20215041)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n아~ 동기시구나~ 저는 이기훈이에요! 우리 말 놔요!";
		}
		else if(count == 20215042)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(당황한 표정을 지으며) 으..응! 나는 " + named + "(이)야.";
		}
		else if(count == 20215043)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n우리 동아리 들어올래? 보드게임 많이 할 수 있어!";
		}
		else if(count == 20215045)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n어! 영준이랑 " + named + "(이)네!!";
		}
		else if(count == 20215046)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n어 안녕. 벌써 동아리 들어갔어?";
		}
		else if(count == 20215047)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n응~ 너도 들어올래? 보드게임 많이 할 수 있어!!";
		}
		else if(count == 20215044 | count == 20215048)
		{
			count = 20215049;
		}
		else if(count == 20215049)
		{
			panel.SetActive(true);
			c1Text.text = "동아리에 들어간다.";			// -> 20215050
			c1.gameObject.SetActive(true);
			c2Text.text = "동아리에 들어가지 않는다.";	// -> 20215055
			c2.gameObject.SetActive(true);
			c2.onClick.AddListener(click_7_2);
		}
		// 씬 6 선택지 7-1
		else if(count == 20215050)
		{
			clear();
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n그래 좋아! 동아리 한 번쯤은 해봐야지!!";
		}
		else if(count == 20215051)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n영준아, 너도 들... 응?";
		}
		else if(count == 20215052)
		{
			dialogueText.text = "<b><size=60></size></b>\n(저기 멀리 영어 회화 동아리 홍보 부스 앞에 기웃거리는 영준이가 보인다.)";
		}
		else if(count == 20215053)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n아휴. 쟤는 공부벌레 같더라고~ 대학생은 놀아야하는데 말이야.";
		}
		// 씬 6 선택지 7-2
		else if(count == 20215055)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(아... 보드게임 별로 안 좋아하는데....)";
		}
		else if(count == 20215056)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n미.. 미안... 이미 생각해놓은 동아리가 있어서!";
		}
		else if(count == 20215057)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n아쉽네~ 그래도 생각 바뀌면 언제든지 들어와!";
		}
		else if(count == 20215058)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n영준아 너는... 응?";
		}
		else if(count == 20215059)
		{
			dialogueText.text = "<b><size=60></size></b>\n(저기 멀리 영어 회화 동아리 홍보 부스 앞에 기웃거리는 영준이가 보인다.)";
		}
		else if(count == 20215060)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n아휴. 쟤는 공부벌레 같더라고~ 대학생은 놀아야하는데 말이야.";
		}
		// 다음 씬
		else if(count == 20215054 | count == 20215060)
		{
			count = 20217000;
		}
		#endregion
		// 씬 7
		#region
		else if (count == 20216000)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n어디서부터 구경할까? 되게 많네...";
		}
		else if(count == 20216001)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n보드게임 동아리 블렌딩 들어오세요~~!!!!";
		}
		else if(count == 20216002)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n저기 엄청 열정적으로 홍보하네. 한번 가볼까?";
		}
		else if(count == 20216003)
		{
			if(!go_ot)
			{
				count = 20216004;
			}
			else
			{
				count = 20216024;
			}
		}
		else if(count == 20216004)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n안녕하세요~ 구경해도 될까요?";
		}
		else if(count == 20216005)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n당연하죠~ 혹시 " + department + "세요? 입학실 때 본거 같은데..?";
		}
		else if(count == 20216006)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n오! 맞아요! 신입생이세요?";
		}
		else if(count == 20216007)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n네! 저 이기훈이에요. 친하게 지내요!!";
		}
		else if(count == 20216008)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n저는 " + named + "(이)라고 해요!";
		}
		else if(count == 20216009)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n저희 서로 동갑인 것 같은데 말 놓을까요?";
		}
		else if(count == 20216010)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n좋아!";
		}
		else if(count == 20216011)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n어? 저기 영준이네? 영준아 이리와봐!";
		}
		else if(count == 20216012)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(누군가 멀리서 걸어온다.)";
		}
		else if(count == 20216013)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n기훈 안녕.";
		}
		else if(count == 20216014)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n얘도 우리과 신입생이야. 인사해.";
		}
		else if(count == 20216015)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n안녕하세요. " + named + "입니다.";
		}
		else if(count == 20216016)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n안녕하세요. 김영준입니다.";
		}
		else if(count == 20216017)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n야. 너네 동갑이야. 말 놓고 친하게 지내~";
		}
		else if(count == 20216018)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n어? 어.. 그럴까?";
		}
		else if(count == 20216019)
		{
			dialogueText.text = "<b><size=60>김영준</size></b>\n그래.";
		}
		else if(count == 20216020)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n우리 동아리 들어와!";
		}
		else if(count == 20216021)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n무슨 동아리인데?";
		}
		else if(count == 20216022)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n보드게임 동아리야! 들어올래?";
		}
		else if(count == 20216023)
		{
			count = 20215049;
		}
		else if(count == 20216024)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n저기.. 구경해도... 어? 기훈이잖아?";
		}
		else if(count == 20216025)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n안녕, 안녕! 우리 동아리 들어올래?";
		}
		else if(count == 20216026)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(쟤는 OT때 화장실에 누워있던데 지금은 괜찮은가 보네.)";
		}
		else if(count == 20216027)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n무슨 동아리인데?";
		}
		else if(count == 20216028)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n보드게임 동아리야! 들어올래?";
		}
		else if(count == 20216029)
		{
			panel.SetActive(true);
			c1Text.text = "동아리에 들어간다.";         // -> 20216030
			c1.gameObject.SetActive(true);
			c2Text.text = "동아리에 들어가지 않는다.";	// -> 20216033
			c2.gameObject.SetActive(true);
			c2.onClick.AddListener(click_8_2);
		}
		else if(count == 20216030)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n그래 좋아! 동아리 한 번쯤은 해봐야지!";
		}
		else if(count == 20216031)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n그래 대학생은 놀아야지!";
		}
		else if(count == 20216033)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n(아.. 보드게임 별로 안좋아하는데...)";
		}
		else if(count == 20216034)
		{
			dialogueText.text = "<b><size=60>" + named + "</size></b>\n미.. 미안... 이미 생각해놓은 동아리가 있어서..!";
		}
		else if(count == 20216035)
		{
			dialogueText.text = "<b><size=60>이기훈</size></b>\n아쉽네. 그래도 생각 바뀌면 언제든지 들어와~!";
		}
		// 다음 씬
		else if(count == 20216032 | count == 20216036)
		{
			count = 20217000;
		}
		#endregion
		else
		{
			Application.Quit();
		}
	}
}