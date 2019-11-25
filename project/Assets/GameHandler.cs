using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;

    private void Start()
    {
        healthBar.SetSize(.4f);
        float health = 1f;
        FunctionPeriodic.Create(() =>
        {
        if (health > 0) ;
        {
            health -= .01f;
            healthBar.SetSize(health);

            if (health < .3f) { }
            //under 30% health
            {
                if (health * 100 % 3 == 0)
                {
                    healthBar.SetColor(Color.white);
                }
                else
                {
                    healthBar.SetColor(Color.red);
                }
            }
        }, .03;
    }
}
