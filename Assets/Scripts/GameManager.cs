using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    public Animator nameColor;
    public Animator overlay;
    public GameObject description;

    public bool isSelected = false;

    // Start is called before the first frame update
    void Start()
    {
        playerName.text = DataManager.instance.playerName;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UIAnimation(bool value)
    {
        nameColor.SetBool("changeColor", value);
        overlay.SetBool("overlay", value);
        description.SetActive(value);
    }

}
