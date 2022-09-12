using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// INHERITANCE
public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    public string shapeName { get;protected set; }

    private string selectedShapeName;
    private Vector3 shapePos;
    private Animator multiColor;

    protected GameManager gameManager;
    protected float duration = 2;

    public Transform placeHolder;
    public Animator overlay;

    private void Awake()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        multiColor = GetComponent<Animator>();
        shapePos = this.transform.position;
    }
    
    private void OnMouseDown()
    {
        ShapeBehaviour();

    }
    // ABSTRACTION
    private void ShapeBehaviour()
    {

        if (gameManager.isSelected && this.gameObject.name == selectedShapeName)
        {
            StartCoroutine(Displace(shapePos, duration));
            gameManager.UIAnimation(false);
            gameManager.isSelected = false;
            multiColor.SetTrigger("color");
            selectedShapeName = null;
        }
        else if (!gameManager.isSelected && selectedShapeName == null)
        {
            StartCoroutine(Displace(placeHolder.position, duration));
            Description();

            gameManager.UIAnimation(true);
            gameManager.isSelected = true;
            multiColor.SetTrigger("color");
            selectedShapeName = this.gameObject.name;
        }
    }
    // POLYMORPHISM
    public abstract void Description();

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

    public void SecondaryInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameManager.isSelected && this.gameObject.name == selectedShapeName)
            {
                StartCoroutine(Displace(shapePos, duration));
                gameManager.UIAnimation(false);
                gameManager.isSelected = false;
                multiColor.SetTrigger("color");
                selectedShapeName = null;
            }
        }
    }
}
