using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour {

	public ImagePosition healthBar;
	public float max_health = 1;
	public float cur_health = 0;

	void Start()
	{
		cur_health = max_health;
		SetHealthBar ();
	}

	public void TakeDamage(float amount)
	{
		cur_health -= amount;
		SetHealthBar ();
	}

	void SetHealthBar()
	{
		float my_Health = cur_health / max_health;
		//healthBar.transform.localscale = new Vector3(Mathf.Clamp(my_Health,0f,1f),healthBar.transform.localscale.y,transform.localScale.z);
	}
}
