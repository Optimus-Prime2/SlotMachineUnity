using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject winBanner;
    public TextMeshProUGUI resultText;
    public Button spinButton;
    public Reel[] reels;
    
    void CheckWin(){
        int a = reels[0].finalIndex;
        int b = reels[1].finalIndex;
        int c = reels[2].finalIndex;

        if (a==b && b ==c){
            resultText.text = "YOU WIN!";
            winBanner.SetActive(true);
        }
        else{
            resultText.text = "TRY AGAIN";
            winBanner.SetActive(true);
        }
    }
    public void StartSpin(){
        spinButton.interactable = false;
        spinButton.image.color = Color.gray;
        winBanner.SetActive(false);
        StartCoroutine(SpinAll());
    }

    IEnumerator SpinAll(){
        for(int i = 0; i < reels.Length; i++){
            yield return StartCoroutine(reels[i].Spin());
        
        }
        CheckWin();
        spinButton.interactable = true;
        spinButton.image.color = Color.white;
    }
}
