using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Shape : MonoBehaviour
{
    private string shapeName;
    private Vector3 shapePos;

    protected GameManager gameManager;
    protected float duration = 2;

    public Transform placeHolder;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        shapePos = this.transform.position;

    }

    private void OnMouseDown()
    {
        if (gameManager.isSelected && this.gameObject.name==shapeName)
        {
            Debug.Log(" 1st if" + shapeName);
            StartCoroutine(Displace(shapePos, duration));
            gameManager.isSelected = false;
            shapeName = null;
        }
        else if (!gameManager.isSelected && shapeName == null)
        {
            Debug.Log(" 2nd if"+shapeName);
            StartCoroutine(Displace(placeHolder.position, duration));
            gameManager.isSelected = true;
            shapeName = this.gameObject.name;
        }
    }

    public IEnumerator Displace(Vector3 targetPosition,float duration)
    {
        float time = 0;
        Vector3 startPos = transform.position;

        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPos, targetPosition, time / duration);
            time+=Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }
}
