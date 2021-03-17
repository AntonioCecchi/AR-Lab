using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int score = 0;

    public TextMeshProUGUI scoreText;
    public ParticleSystem ScoreParticle;

    private void Update()
    {
        scoreText.text = score.ToString();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Scoring();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            Scoring();
        }
    }

    public void Scoring()
    {
        score++;

        ScoreParticle.Play();
    }
}
