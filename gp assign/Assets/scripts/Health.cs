using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public float Hp, MaxHealth, Width, height;
    [SerializeField]
    private RectTransform healthbar;
    public void SetMaxHealth(float maxHealth) {
        MaxHealth = maxHealth;
    }
    public void SetHealth(float Health)
    {
        Hp = Health;
        float newWidth = (Hp / MaxHealth) * Width;
        healthbar.sizeDelta = new Vector2(newWidth,height);
    }
}
