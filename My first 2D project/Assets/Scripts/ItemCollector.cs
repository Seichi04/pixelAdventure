using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int bananas = 0;

    [SerializeField] private TextMeshProUGUI BananaText;
    [SerializeField] private AudioSource ItemCollecSoundEffect;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Banana"))
        {
            Destroy(collision.gameObject);
            ItemCollecSoundEffect.Play();
            bananas++;
            BananaText.text = "Banana: " + bananas;
        }
    }
}
