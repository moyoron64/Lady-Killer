using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {

	private int score1,score2,score3,score4,score5,score6,score0,score7;
	GameObject po01,po02,po03,po04,
	po05,
	po06,
	po07,
	po08,
	po09,
	po00,
	po11,
	po12,
	po13,
	po14,
	po15,
	po16,
	po17,
	po18,
	po19,
	po10,
	po21,
	po22,
	po23,
	po24,
	po25,
	po26,
	po27,
	po28,
	po29,
	po20,
	
	
	
	po31,
	po32,
	po33,
	po34,
	po35,
	po36,
	po37,
	po38,
	po39,
	po30,
	
	
	
	po41,
	po42,
	po43,
	po44,
	po45,
	po46,
	po47,
	po48,
	po49,
	po40,
	
	
	po51,
	po52,
	po53,
	po54,
	po55,
	po56,
	po57,
	po58,
	po59,
	po50,
	
	
	
	po61,
	po62,
	po63,
	po64,
	po65,
	po66,
	po67,
	po68,
	po69,
	po60,
	
	
	po71,
	po72,
	po73,
	po74,
	po75,
	po76,
	po77,
	po78,
	po79,
	po70,

	po81,
	po82,
	po83,
	po84,
	po85,
	po86,
	po87,
	po88,
	po89,
	po80;
	int score;
	
	// Use this for initialization
	void Start () {
		score = 0;
		/*kihonkei
		po71 = GameObject.Find("koko1");
		po72 = GameObject.Find("koko2");
		po73 = GameObject.Find("koko3");
		po74 = GameObject.Find("koko4");
		po75 = GameObject.Find("koko5");
		po76 = GameObject.Find("koko6");
		po77 = GameObject.Find("koko7");
		po78 = GameObject.Find("koko8");
		po79 = GameObject.Find("koko9");
		po70 = GameObject.Find("koko0");
		po71.renderer.enabled = false;
		po72.renderer.enabled = false;
		po73.renderer.enabled = false;
		po74.renderer.enabled = false;
		po75.renderer.enabled = false;
		po76.renderer.enabled = false;
		po77.renderer.enabled = false;
		po78.renderer.enabled = false;
		po79.renderer.enabled = false;
		po70.renderer.enabled = false;
		*/
		
		po01 = GameObject.Find("01");
		po02 = GameObject.Find("02");
		po03 = GameObject.Find("03");
		po04 = GameObject.Find("04");
		po05 = GameObject.Find("05");
		po06 = GameObject.Find("06");
		po07 = GameObject.Find("07");
		po08 = GameObject.Find("08");
		po09 = GameObject.Find("09");
		po00 = GameObject.Find("00");
		po01.renderer.enabled = false;
		po02.renderer.enabled = false;
		po03.renderer.enabled = false;
		po04.renderer.enabled = false;
		po05.renderer.enabled = false;
		po06.renderer.enabled = false;
		po07.renderer.enabled = false;
		po08.renderer.enabled = false;
		po09.renderer.enabled = false;
		po00.renderer.enabled = false;
		
		
		po11 = GameObject.Find("11");
		po12 = GameObject.Find("12");
		po13 = GameObject.Find("13");
		po14 = GameObject.Find("14");
		po15 = GameObject.Find("15");
		po16 = GameObject.Find("16");
		po17 = GameObject.Find("17");
		po18 = GameObject.Find("18");
		po19 = GameObject.Find("19");
		po10 = GameObject.Find("10");
		po11.renderer.enabled = false;
		po12.renderer.enabled = false;
		po13.renderer.enabled = false;
		po14.renderer.enabled = false;
		po15.renderer.enabled = false;
		po16.renderer.enabled = false;
		po17.renderer.enabled = false;
		po18.renderer.enabled = false;
		po19.renderer.enabled = false;
		po10.renderer.enabled = false;
		
		po21 = GameObject.Find("21");
		po22 = GameObject.Find("22");
		po23 = GameObject.Find("23");
		po24 = GameObject.Find("24");
		po25 = GameObject.Find("25");
		po26 = GameObject.Find("26");
		po27 = GameObject.Find("27");
		po28 = GameObject.Find("28");
		po29 = GameObject.Find("29");
		po20 = GameObject.Find("20");
		po21.renderer.enabled = false;
		po22.renderer.enabled = false;
		po23.renderer.enabled = false;
		po24.renderer.enabled = false;
		po25.renderer.enabled = false;
		po26.renderer.enabled = false;
		po27.renderer.enabled = false;
		po28.renderer.enabled = false;
		po29.renderer.enabled = false;
		po20.renderer.enabled = false;
		
		
		po31 = GameObject.Find("31");
		po32 = GameObject.Find("32");
		po33 = GameObject.Find("33");
		po34 = GameObject.Find("34");
		po35 = GameObject.Find("35");
		po36 = GameObject.Find("36");
		po37 = GameObject.Find("37");
		po38 = GameObject.Find("38");
		po39 = GameObject.Find("39");
		po30 = GameObject.Find("30");
		po31.renderer.enabled = false;
		po32.renderer.enabled = false;
		po33.renderer.enabled = false;
		po34.renderer.enabled = false;
		po35.renderer.enabled = false;
		po36.renderer.enabled = false;
		po37.renderer.enabled = false;
		po38.renderer.enabled = false;
		po39.renderer.enabled = false;
		po30.renderer.enabled = false;
		
		
		po41 = GameObject.Find("41");
		po42 = GameObject.Find("42");
		po43 = GameObject.Find("43");
		po44 = GameObject.Find("44");
		po45 = GameObject.Find("45");
		po46 = GameObject.Find("46");
		po47 = GameObject.Find("47");
		po48 = GameObject.Find("48");
		po49 = GameObject.Find("49");
		po40 = GameObject.Find("40");
		po41.renderer.enabled = false;
		po42.renderer.enabled = false;
		po43.renderer.enabled = false;
		po44.renderer.enabled = false;
		po45.renderer.enabled = false;
		po46.renderer.enabled = false;
		po47.renderer.enabled = false;
		po48.renderer.enabled = false;
		po49.renderer.enabled = false;
		po40.renderer.enabled = false;
		
		
		po51 = GameObject.Find("51");
		po52 = GameObject.Find("52");
		po53 = GameObject.Find("53");
		po54 = GameObject.Find("54");
		po55 = GameObject.Find("55");
		po56 = GameObject.Find("56");
		po57 = GameObject.Find("57");
		po58 = GameObject.Find("58");
		po59 = GameObject.Find("59");
		po50 = GameObject.Find("50");
		po51.renderer.enabled = false;
		po52.renderer.enabled = false;
		po53.renderer.enabled = false;
		po54.renderer.enabled = false;
		po55.renderer.enabled = false;
		po56.renderer.enabled = false;
		po57.renderer.enabled = false;
		po58.renderer.enabled = false;
		po59.renderer.enabled = false;
		po50.renderer.enabled = false;
		
		
		po61 = GameObject.Find("61");
		po62 = GameObject.Find("62");
		po63 = GameObject.Find("63");
		po64 = GameObject.Find("64");
		po65 = GameObject.Find("65");
		po66 = GameObject.Find("66");
		po67 = GameObject.Find("67");
		po68 = GameObject.Find("68");
		po69 = GameObject.Find("69");
		po60 = GameObject.Find("60");
		po61.renderer.enabled = false;
		po62.renderer.enabled = false;
		po63.renderer.enabled = false;
		po64.renderer.enabled = false;
		po65.renderer.enabled = false;
		po66.renderer.enabled = false;
		po67.renderer.enabled = false;
		po68.renderer.enabled = false;
		po69.renderer.enabled = false;
		po60.renderer.enabled = false;
		
		po71 = GameObject.Find("71");
		po72 = GameObject.Find("72");
		po73 = GameObject.Find("73");
		po74 = GameObject.Find("74");
		po75 = GameObject.Find("75");
		po76 = GameObject.Find("76");
		po77 = GameObject.Find("77");
		po78 = GameObject.Find("78");
		po79 = GameObject.Find("79");
		po70 = GameObject.Find("70");
		po71.renderer.enabled = false;
		po72.renderer.enabled = false;
		po73.renderer.enabled = false;
		po74.renderer.enabled = false;
		po75.renderer.enabled = false;
		po76.renderer.enabled = false;
		po77.renderer.enabled = false;
		po78.renderer.enabled = false;
		po79.renderer.enabled = false;
		po70.renderer.enabled = false;

		po81 = GameObject.Find("81");
		po82 = GameObject.Find("82");
		po83 = GameObject.Find("83");
		po84 = GameObject.Find("84");
		po85 = GameObject.Find("85");
		po86 = GameObject.Find("86");
		po87 = GameObject.Find("87");
		po88 = GameObject.Find("88");
		po89 = GameObject.Find("89");
		po80 = GameObject.Find("80");
		po81.renderer.enabled = false;
		po82.renderer.enabled = false;
		po83.renderer.enabled = false;
		po84.renderer.enabled = false;
		po85.renderer.enabled = false;
		po86.renderer.enabled = false;
		po87.renderer.enabled = false;
		po88.renderer.enabled = false;
		po89.renderer.enabled = false;
		po80.renderer.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		score =PlayerPrefs.GetInt("Score");
		
		
		score0 = score % 10;
		score1 = score % 100 /10;
		score2 = score % 1000/100;
		score3 = score % 10000/1000;
		score4 = score % 100000/10000;
		score5 = score % 1000000/100000;
		score6 = score % 10000000/1000000;
		score7 = score / 100000000;
		

		
		if(score0==0)po00.renderer.enabled= true;
		if(score0==1)po01.renderer.enabled= true;
		if(score0==2)po02.renderer.enabled= true;
		if(score0==3)po03.renderer.enabled= true;
		if(score0==4)po04.renderer.enabled= true;
		if(score0==5)po05.renderer.enabled= true;
		if(score0==6)po06.renderer.enabled= true;
		if(score0==7)po07.renderer.enabled= true;
		if(score0==8)po08.renderer.enabled= true;
		if(score0==9)po09.renderer.enabled= true;
		
		if(score1==0)po10.renderer.enabled= true;
		if(score1==1)po11.renderer.enabled= true;
		if(score1==2)po12.renderer.enabled= true;
		if(score1==3)po13.renderer.enabled= true;
		if(score1==4)po14.renderer.enabled= true;
		if(score1==5)po15.renderer.enabled= true;
		if(score1==6)po16.renderer.enabled= true;
		if(score1==7)po17.renderer.enabled= true;
		if(score1==8)po18.renderer.enabled= true;
		if(score1==9)po19.renderer.enabled= true;
		
		if(score2==0)po20.renderer.enabled= true;
		if(score2==1)po21.renderer.enabled= true;
		if(score2==2)po22.renderer.enabled= true;
		if(score2==3)po23.renderer.enabled= true;
		if(score2==4)po24.renderer.enabled= true;
		if(score2==5)po25.renderer.enabled= true;
		if(score2==6)po26.renderer.enabled= true;
		if(score2==7)po27.renderer.enabled= true;
		if(score2==8)po28.renderer.enabled= true;
		if(score2==9)po29.renderer.enabled= true;
		
		if(score3==0)po30.renderer.enabled= true;
		if(score3==1)po31.renderer.enabled= true;
		if(score3==2)po32.renderer.enabled= true;
		if(score3==3)po33.renderer.enabled= true;
		if(score3==4)po34.renderer.enabled= true;
		if(score3==5)po35.renderer.enabled= true;
		if(score3==6)po36.renderer.enabled= true;
		if(score3==7)po37.renderer.enabled= true;
		if(score3==8)po38.renderer.enabled= true;
		if(score3==9)po39.renderer.enabled= true;
		
		if(score4==0)po40.renderer.enabled= true;
		if(score4==1)po41.renderer.enabled= true;
		if(score4==2)po42.renderer.enabled= true;
		if(score4==3)po43.renderer.enabled= true;
		if(score4==4)po44.renderer.enabled= true;
		if(score4==5)po45.renderer.enabled= true;
		if(score4==6)po46.renderer.enabled= true;
		if(score4==7)po47.renderer.enabled= true;
		if(score4==8)po48.renderer.enabled= true;
		if(score4==9)po49.renderer.enabled= true;
		
		if(score5==0)po50.renderer.enabled= true;
		if(score5==1)po51.renderer.enabled= true;
		if(score5==2)po52.renderer.enabled= true;
		if(score5==3)po53.renderer.enabled= true;
		if(score5==4)po54.renderer.enabled= true;
		if(score5==5)po55.renderer.enabled= true;
		if(score5==6)po56.renderer.enabled= true;
		if(score5==7)po57.renderer.enabled= true;
		if(score5==8)po58.renderer.enabled= true;
		if(score5==9)po59.renderer.enabled= true;
		
		if(score6==0)po60.renderer.enabled= true;
		if(score6==1)po61.renderer.enabled= true;
		if(score6==2)po62.renderer.enabled= true;
		if(score6==3)po63.renderer.enabled= true;
		if(score6==4)po64.renderer.enabled= true;
		if(score6==5)po65.renderer.enabled= true;
		if(score6==6)po66.renderer.enabled= true;
		if(score6==7)po67.renderer.enabled= true;
		if(score6==8)po68.renderer.enabled= true;
		if(score6==9)po69.renderer.enabled= true;

		if(score7==0)po70.renderer.enabled= true;
		if(score7==1)po71.renderer.enabled= true;
		if(score7==2)po72.renderer.enabled= true;
		if(score7==3)po73.renderer.enabled= true;
		if(score7==4)po74.renderer.enabled= true;
		if(score7==5)po75.renderer.enabled= true;
		if(score7==6)po76.renderer.enabled= true;
		if(score7==7)po77.renderer.enabled= true;
		if(score7==8)po78.renderer.enabled= true;
		if(score7==9)po79.renderer.enabled= true;
		

	
	}
}
