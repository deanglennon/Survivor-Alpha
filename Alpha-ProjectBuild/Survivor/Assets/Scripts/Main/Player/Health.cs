using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
	private int maxHealth = 5;
	public int health;
	
    void Start()
    {
        health = maxHealth;
    }

	public void TakeDamage(int damage)
	{
		health -= damage;
		if(health <= 0)
		{
			SceneManager.LoadScene(sceneName: "Menu");
		}
	}
}
