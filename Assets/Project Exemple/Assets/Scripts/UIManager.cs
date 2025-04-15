using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI positionText;
    public Image hpBarImage;

    [Header("References")]
    public PlayerController player;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        positionText.text = "Position : " + player.transform.position;
        hpBarImage.fillAmount -= 0.05f * Time.deltaTime;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HideButton()
    {
        animator.SetBool("IsButtonActive", !animator.GetBool("IsButtonActive"));
    }
}
