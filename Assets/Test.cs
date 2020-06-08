using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
	private int mp = 53;

	public void Magic()
    {
		this.mp -= 5;
		Debug.Log("魔法攻撃をした。残りMPは" + this.mp);

		if (this.mp < 5)
        {
			Debug.Log("MPが足りないため魔法が使えない。");

        }
    }

}


public class Test : MonoBehaviour {


    void Start()
    {
		int[] array = new int[5];

		array[0] = 1;
		array[1] = 2;
		array[2] = 3;
		array[3] = 4;
		array[4] = 5;

		for (int i = 0; i < 5; i++)
        {
			Debug.Log(array[i]);
        }

		for (int i = 4; i >= 0; i--)
        {
			Debug.Log(array[i]);
        }




		Boss lastboss = new Boss();

		lastboss.Magic();
		
		

	}



	






		// Update is called once per frame
		void Update () {
		
	}
}
