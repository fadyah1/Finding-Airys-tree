using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class SpeechRecognitionEngine : MonoBehaviour
{
    public string[] keywords = new string[] { "up", "down", "left", "right" };
    public ConfidenceLevel confidence = ConfidenceLevel.Medium;
    public float speed = 0.9f;
    public string word = "right";

    public Image player;

    protected PhraseRecognizer recognizer;
    //protected string word = "right";

    private void Start()
    {
        if (keywords != null)
        {
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
            Debug.Log(recognizer.IsRunning);
        }

        foreach (var device in Microphone.devices)
        {
            Debug.Log("Name: " + device);
        }
    }

    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        word = args.text;
    }

    private void Update()
    {
        var x = player.transform.position.x;
        var y = player.transform.position.y;

        switch (word)
        {
            case "up":
                y += speed;
                break;
            case "down":
                y -= speed;
                break;
            case "left":
                x -= speed;
                break;
            case "right":
                x += speed;
                break;
        }

        player.transform.position = new Vector3(x, y, 0);
    }

    private void OnApplicationQuit()
    {
        if (recognizer != null && recognizer.IsRunning)
        {
            recognizer.OnPhraseRecognized -= Recognizer_OnPhraseRecognized;
            recognizer.Stop();
        }
    }
}

