using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllKeywordsGroup : MonoBehaviour
{

    static public AllKeywordsGroup instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
    }

    public List<Keywords> KeywordList = new List<Keywords>();
    // Start is called before the first frame update
    void Start()
    {
        //이지윤
        KeywordList.Add(new Keywords(80000, "침착", "혼란스러운 상황에서도 평정심을 잃지 않는다.", 0, 0));
        KeywordList.Add(new Keywords(80001, "의문의 납치", "하굣길에 이유를 알 수 없는 납치를 당했다.", 0, 0));
        KeywordList.Add(new Keywords(80002, "대학생", "대학생이다.", 0, 0));
        KeywordList.Add(new Keywords(80003, "도화선", "작은 메모지에 이 단어만 적혀 있다. 내 죄와 관련이 있는 단어라고 했다.", 0, 0));
        KeywordList.Add(new Keywords(80004, "'그 일'", "과거에 어떤 일을 겪고 편히 자지 못했다.", 0, 0));

        //도재하
        KeywordList.Add(new Keywords(10000, "데뷔 예정인 아이돌", "이름이 익숙했던 건 유명 프로그램에 나와서였다. 데뷔 예정이라고 한다.", 0, 0));
        KeywordList.Add(new Keywords(10001, "데뷔 예정인 아이돌?", "데뷔가 얼마 안 남았을 텐데 의연한 모습이다. 정말 데뷔 예정이 맞는 걸까?", 0, 0));
        KeywordList.Add(new Keywords(10002, "스포트라이트9", "유명 아이돌 데뷔 프로그램이다. 도재하가 이 프로그램 출신이다.", 0, 0));
        KeywordList.Add(new Keywords(10003, "나비효과", "도재하가 받은 쪽지의 내용이다.", 0, 0));
        KeywordList.Add(new Keywords(10004, "적극성", "남들이 안 나서고 있을 때 적극적으로 행동하는 것 같다.", 0, 0));

        //민재현
        KeywordList.Add(new Keywords(20000, "까칠함", "존댓말을 쓰지만 말투가 까칠하다.", 0, 0));
        KeywordList.Add(new Keywords(20001, "고등학생", "고등학생이라고 한다.", 0, 0));
        KeywordList.Add(new Keywords(20002, "기폭", "민재현이 받은 쪽지의 내용이다.", 0, 0));
        KeywordList.Add(new Keywords(20003, "담존고등학교", "민재현이 재학 중인 학교다. 사립 일반 고등학교로, 대학 진학 실적이 좋은 걸로 신문에 몇 번 나왔다.", 0, 0));

        //손미진
        KeywordList.Add(new Keywords(30000, "넉살", "우리가 처한 상황에도 불구하고 밝은 모습이다. 아직 이 사태를 실감하고 있지 못한 걸까?", 0, 0));
        KeywordList.Add(new Keywords(30001, "탐욕", "손미진이 받은 쪽지의 내용이다.", 0, 0));

        //지선경
        KeywordList.Add(new Keywords(40000, "경계심", "태도가 신중하고 시종일관 예민하게 주변을 살피고 있다.", 0, 0));
        KeywordList.Add(new Keywords(40001, "현혹", "지선경이 받은 쪽지의 내용이다.", 0, 0));

        //리차드
        KeywordList.Add(new Keywords(50000, "싼티와 부티", "저렴한 말투에 비해 차려입은 옷은 다 브랜드다.", 0, 0));
        KeywordList.Add(new Keywords(50001, "건물주", "묻지도 않았는데 자신이 여러 건물을 가지고 있다고 밝혔다. (부럽다.)", 0, 0));
        KeywordList.Add(new Keywords(50002, "다혈질", "화가 많은 것 같다. 고혈압이 걱정된다.", 0, 0));

        //강광철
        KeywordList.Add(new Keywords(60000, "기업가", "KC기업의 대표이다. 누구나 한 번쯤 들어본 적 있을 정도로 유명한 사람이다.", 0, 0));
        KeywordList.Add(new Keywords(60001, "시발점", "강광철이 받은 쪽지의 내용이다.", 0, 0));
        KeywordList.Add(new Keywords(60002, "트로피", "혁신적인 기술을 가지고 있는 회사에게 주어지는 트로피이다. 전부 KC기업의 이름이 적혀있다. ", 0, 0));
        KeywordList.Add(new Keywords(60003, "오래된 신문", "1998년에 나온 신문이다. 강휘기업의 근무자 여럿이 과로사했다는 기사다.", 0, 0));
        KeywordList.Add(new Keywords(60004, "여러 장의 사진", "회사 워크샵 때 찍은 사진 같다. 순서대로 1985년(강휘기업), 2000년(KC 출범식), 2015년(KC그룹 15주년)이라고 적혀있다.", 0, 0));
        KeywordList.Add(new Keywords(60005, "잠긴 노트북", "강광철의 노트북인 것 같다. 잠금이 걸려 있다.", 0, 0));
        KeywordList.Add(new Keywords(60006, "노트북", "강광철의 노트북이다. 잠금을 해제했다.", 0, 0));
        KeywordList.Add(new Keywords(60007, "사업 서류들", "강광철의 노트북 안에 있는 사업에 관련된 서류들이다. 모든 서류의 작성자 이름 부분은 수정된 적이 있다.", 0, 0));
        KeywordList.Add(new Keywords(60008, "물병", "강광철이 어제 가져간 물병이다. 남아 있는 것도 특이한 것도 없다.", 0, 0));
        KeywordList.Add(new Keywords(60009, "강휘기업", "강광철이 회장으로 있는 KC 그룹의 전신이다. 기업 이미지 때문에 KC 기업으로 이름이 바뀌었다.", 0, 0));

        //기타(9 + 4 + 6 + 3)
        KeywordList.Add(new Keywords(70000, "키패드", "키패드에 불이 들어왔다. 이제 숫자를 입력할 수 있을 것 같다.", 0, 0));
        KeywordList.Add(new Keywords(70001, "스크린", "화면에 아까 말한 규칙들이 적혀 있다.", 0, 0));
        KeywordList.Add(new Keywords(70002, "규칙", "스크린에 섬뜩한 규칙들이 적혀져 있다.", 0, 0));
        KeywordList.Add(new Keywords(70003, "바닥에 떨어진 종이", "앞면은 00은행에서 돈을 이체한 내역이 적혀 있다. 금 일천이백삼십오만원을 누군가에게 보낸 내역이다. 보낸 사람과 받은 사람에 대한 정보는 알 수 없다. 종이 뒷면에는 알 수 없는 수식이 적혀 있다.", 0, 0));
        KeywordList.Add(new Keywords(70004, "방의 방음", "방음이 완벽하게 되지 않는다. 고래고래 소리를 지르면 문 바로 반대편에 있는 사람에게는 뭐라고 말하고 있는지 대충 들린다.", 0, 0));
        KeywordList.Add(new Keywords(70005, "식탁", "식탁엔 일곱개의 의자와 긴 테이블이 놓여 있다.", 0, 0));
        KeywordList.Add(new Keywords(70006, "냉장고", "플라스틱 물통 여러 개와 식사대용 선식 가루가 든 통이 있다.", 0, 0));
        KeywordList.Add(new Keywords(70007, "화장실", "변기와 세면대만 있는 간단한 화장실이다. 몸을 씻을 순 없을 것 같다.", 0, 0));
        KeywordList.Add(new Keywords(70008, "메인 룸의 시계", "어디서든 볼 수 있는 흔한 시계다.", 0, 0));

        KeywordList.Add(new Keywords(70010, "의문점1", "내가 저지른 죄를 기억해내라고 한다. 당장 짚이는 구석은 없다.", 0, 0));
        KeywordList.Add(new Keywords(70011, "의문점2", "사람을 죽인다고 했다. 정말일까? 정말이라면 당장 여기서 나가야 한다.", 0));
        KeywordList.Add(new Keywords(70012, "의문점3", "나 말고 다른 사람도 있는 듯 하다. 몇 명이나 여기 있는 걸까? 나와 안면이 있는 사람은 있을까?", 0, 0));
        KeywordList.Add(new Keywords(70912, "의문점3", "총 7명의 사람들이 모였다. 서로 일방적으로 아는 사람은 있어도 알고 지낸 사람은 없는 것 같다.", 0, 0));

        KeywordList.Add(new Keywords(70013, "의문점4", "다른 사람들도 쪽지를 받았을까? 받았다면 무슨 내용일까?", 0, 0));
        KeywordList.Add(new Keywords(70014, "의문점5", "출구 없는 밀실에 갇혔다. 이게 가능한 일인가? 그럼 여기 어떻게 들어온 거지?", 0, 0));
        KeywordList.Add(new Keywords(70015, "의문점6", "리차드가 받은 쪽지에는 무엇이 써져 있을까? 대화를 해서 알아낼 수는 없을까?", 0, 0));
        KeywordList.Add(new Keywords(70016, "의문점7", "민재현은 도재하한테 왜 까칠하게 구는 걸까?", 0, 0));
        KeywordList.Add(new Keywords(70017, "의문점8", "강광철은 왜 도재하를 달가워하지 않았을까?", 0, 0));
        KeywordList.Add(new Keywords(70018, "의문점9", "민재현은 리차드에 대한 감정이 안 좋아보인다. 왜일까?", 0, 0));

        KeywordList.Add(new Keywords(70019, "방문", "방문이 잠겨있다. 무력으로는 열 수 없을 것 같다.", 0, 0));
        KeywordList.Add(new Keywords(70020, "키패드", "문 옆에는 키패드가 달려 있다. 현재 전기가 나갔는지 어떤 버튼을 눌러도 작동하지 않는다.", 0, 0));
        KeywordList.Add(new Keywords(70021, "스크린", "엄청나게 큰 TV 화면이다. 어떤 버튼도 보이지 않는다.", 0, 0));

    }


}
