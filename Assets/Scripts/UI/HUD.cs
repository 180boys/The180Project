using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [Header("HUD Links")]
    public Image HPBar;
    public Image MovementBar;
    public Image ShootBar;
    public Image EnemyBar;
    public bool BossShow;

    [Header("Floats and ints")]
    int sign = 1;

    //HP
    [SerializeField]
    private float HPpercentage;

    void Start()
    {
        ////Calls whatever I need from Character script
        GameObject Player = GameObject.Find("MAINCHARACTER");
        Character Character = Player.GetComponent<Character>();
        Character.Health -= HPpercentage;

        //For HP Bar conversion
        if (HPBar != null)
        {
            HPpercentage = HPBar.fillAmount * 100;
        }
    }

    public void Update()
    {
        //HP Percentage
        HPpercentage += sign;
        if (HPpercentage >= 100 || HPpercentage <= 0)
        {
            sign *= -1;
            HPpercentage = ((HPpercentage <= 0) ? 0 : 100);
        }
    }
}
