using UnityEngine;
using System.Collections;

public class Boss {
	private int mp = 53;

	// 魔法用の関数
	public void Magic(){
		this.mp -= 5;
		if (this.mp > 5){
			Debug.Log ("魔法攻撃をした。残りMPは"+ this.mp);
		}else{
			Debug.Log( "MPが足りないため魔法が使えない。" );
		};			
	}
}

public class boss : MonoBehaviour {
	void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();
		// 魔法用の関数を呼び出す
		for (int i = 1; i < 12; i++) {
				lastboss.Magic();	
		}
	}
	// Update is called once per frame
	void Update () {
	}
}