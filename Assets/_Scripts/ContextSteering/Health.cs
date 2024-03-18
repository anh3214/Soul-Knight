using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField]
    public int currentHealth, maxHealth, currentShiled, maxShiled;

    public UnityEvent<GameObject> OnHitWithReference, OnDeathWithReference;

    public bool isDead = false;

    public void InitializeHealth(int healthValue)
    {
        currentHealth = healthValue;
        maxHealth = healthValue;
        isDead = false;
    }

    public void GetHit(int amount, GameObject sender)
    {
        if (isDead)
            return;
        if (sender.layer == gameObject.layer)
            return;
        if(currentShiled != 0)
        {
            currentShiled -= amount;
        }
        else
        {
            currentHealth -= amount;
        }

        if (currentHealth  > 0 || currentShiled > 0)
        {
            OnHitWithReference?.Invoke(sender);
        }
        else
        {
            OnDeathWithReference?.Invoke(sender);
            if (gameObject.CompareTag("Player")&& gameObject.layer == 8)
            {
                GameObject game = GameObject.Find("CanvasOver");
                GameOverScreen over = game.GetComponent<GameOverScreen>();
                over.GameOver();
            }
            isDead = true; 
            Destroy(gameObject);
        }
    }
}
