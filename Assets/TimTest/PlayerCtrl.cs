using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour
{
    public bool loop;

    public Transform[] wayPoints;

    public Text scoreText;
    int currentIndex;
    int size;

    int points = 0;

    private void Start()
    {
        size = wayPoints.Length;
        currentIndex = 0;
        UpdatePosition();
        UpdatePointsDisplay();
    }

    public void MoveUp()
    {
        if (currentIndex < (size - 1))
        {
            currentIndex++;
            UpdatePosition();
        }
        else if (loop)
        {
            currentIndex = 0;
            UpdatePosition();
        }
    }

    public void MoveDown()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            UpdatePosition();
        }
        else if (loop)
        {
            currentIndex = size - 1;
            UpdatePosition();
        }
    }

    private void UpdatePosition()
    {
        transform.position = wayPoints[currentIndex].position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent<Ennemy>())
        {
            other.GetComponent<Ennemy>().DestroyEnnemy();
            points++;
            UpdatePointsDisplay();
        }
    }

    private void UpdatePointsDisplay()
    {
        scoreText.text = points.ToString();
    }

    public void ResetPoint()
    {
        points = 0;
        UpdatePointsDisplay();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
