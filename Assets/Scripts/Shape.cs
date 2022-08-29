using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Shape : MonoBehaviour
{
    [SerializeField]
    float duration = 2;

    public Transform placeHolder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log(name);
        StartCoroutine(Displace(placeHolder.position, duration));
    }

    IEnumerator Displace(Vector3 targetPosition,float duration)
    {
        float time = 0;
        Vector3 startPos=transform.position;

        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPos, targetPosition, time / duration);
            time+=Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }
}
