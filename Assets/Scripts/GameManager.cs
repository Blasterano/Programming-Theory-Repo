using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playerName;
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

    
}
