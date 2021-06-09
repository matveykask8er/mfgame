using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class weather : MonoBehaviour
{
    private string url = "https://api.openweathermap.org/data/2.5/weather?q=Smolensk&appid=02098b8ea1de1ba66e467a721e1369bc&units=metric";
    void Start()
    {
        StartCoroutine(routine: SendRequest());
    }
    private IEnumerator SendRequest()
    {
        UnityWebRequest request = UnityWebRequest.Get(this.url);
        yield return request.SendWebRequest();
        Regex regex = new Regex("\"temp\":(.*),\"feels_like\"");
        Match match = regex.Match(request.downloadHandler.text);
        Debug.Log(match.Success);
        Debug.Log(match.Groups[1].Value);
        GameObject.Find("Weather").GetComponent<Text>().text = "Temp: " + match.Groups[1].Value.ToString();
        //double temp = JSON.Parse(request.downloadHandler.text)["main"]["temp"].AsFloat;
        //Debug.Log(temp);
    }
}