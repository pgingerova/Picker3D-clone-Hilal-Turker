using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgressUI : MonoBehaviour
{
    [Header("UI references :")]
    [SerializeField] private Image uiFillImage;
    [SerializeField] private Text uiStartText;
    [SerializeField] private Text uiFinishText;

    [Header("Player  Endline references :")]
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform endLineTransform;

    private Vector3 endLinePosition;

    private float fullDistance;

    private void Start()
    {
        endLinePosition = endLineTransform.position;
        fullDistance = GetDistance();
    }

    public void SetLevelTexts(int level)
    {
        uiStartText.text = level.ToString();
        uiStartText.text = (level+1).ToString();
    }

    private float GetDistance()
    {
        return Vector3.Distance(playerTransform.position, endLinePosition);
    }

    private void UpdateProgressFill(float value)
    {
        uiFillImage.fillAmount = value;
    }

    private void Update ()
    {
        float newDistance = GetDistance ();
        float progressValue = Mathf.InverseLerp(fullDistance, 0f, newDistance);
        UpdateProgressFill(progressValue);
        

    }
   
}
