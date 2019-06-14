using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;

    [SerializeField]
    private Text factText;
    [SerializeField]
    private Text leftanswer;
    [SerializeField]
    private Text rightanswer;

    [SerializeField]
    private float timeBetweenQuestions = 1f;
    
    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        SetCurrentQuestion();
        Debug.Log(currentQuestion.fact + "is" + currentQuestion.isTrue);
    }

    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        factText.text = currentQuestion.fact;
        leftanswer.text = currentQuestion.left;
        rightanswer.text = currentQuestion.right;
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        SetCurrentQuestion();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectTrue()
    {
        if(currentQuestion.isTrue)
        {
            Debug.Log("Correct");
            Uicontroller.iscorrect = true;
        }
        else
        {
            Debug.Log("Wrong");
            Uicontroller.iscorrect = false;
            Uicontroller.iswrong = true;
        }

        StartCoroutine(TransitionToNextQuestion());
    }
    public void UserSelectfalse()
    {
        if (!currentQuestion.isTrue)
        {
            Debug.Log("Correct");
            Uicontroller.iscorrect = true;
        }
        else
        {
            Debug.Log("Wrong");
            Uicontroller.iscorrect = false;
            Uicontroller.iswrong = true;
        }

        StartCoroutine(TransitionToNextQuestion());
    }
}
