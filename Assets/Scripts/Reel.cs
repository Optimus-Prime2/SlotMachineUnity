using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Reel : MonoBehaviour
{
    public int finalIndex;
    public Sprite[] Symbols;
    public Image displayImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    public IEnumerator Spin(){
        float timer = 0f;
        float duration = 3f;
        while (timer< duration){
            int rand = Random.Range(0, Symbols.Length);
            displayImage.sprite = Symbols[rand];

            timer += Time.deltaTime;

            yield return null;
        }
        finalIndex  = Random.Range(0, Symbols.Length);
        displayImage.sprite = Symbols[finalIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
