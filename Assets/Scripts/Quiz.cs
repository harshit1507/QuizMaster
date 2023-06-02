using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] private QuestionsSO question;
    [SerializeField] private TextMeshProUGUI questionText;
    void Start()
    {
        questionText.text = question.GetQuestion();
    }
}
