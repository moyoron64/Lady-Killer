using UnityEngine;

public class Score : MonoBehaviour
{
	// スコアを表示するGUIText
	public GUIText scoreGUIText;
	public GUIText nokoriScoreGUIText;
	public GUIText kyoriScoreGUIText;
	
	// スコア
	private int timescore;
	private int nokoriscore;
	private int kyoriscore;
	
	// ハイスコア
	
	
	void Start ()
	{
		Initialize ();
	}
	
	void Update ()
	{
			
		// スコア・ハイスコアを表示する
		scoreGUIText.text = "TimeScore : " +timescore.ToString ();
		kyoriScoreGUIText.text = "KyoriScore : " +kyoriscore.ToString ();
		nokoriScoreGUIText.text = "NokoriScore : " +nokoriscore.ToString ();
	}
	
	// ゲーム開始前の状態に戻す
	private void Initialize ()
	{
		// スコアを0に戻す
		timescore = 1111111;
		kyoriscore = 2111111;
		nokoriscore = 2311111;
	}
	

	// ハイスコアの保存
	public void Save ()
	{
		// ハイスコアを保存する
		//PlayerPrefs.SetInt (highScoreKey, highScore);
		//PlayerPrefs.Save ();
		
		// ゲーム開始前の状態に戻す
		Initialize ();
	}
}