using UnityEngine;
using UnityEngine.UI;

public class TypeEffect : MonoBehaviour
{
    public int CharPerSeconde;
    public GameObject EndCursor;

    AudioSource audioSource;
    Text msgText;
    string targetMsg;
    int index;
    float interval;
    public bool isAnimation;

    public void Awake()
    {
        msgText = GetComponent<Text>();    
        audioSource = GetComponent<AudioSource>();
    }

    public void SetMsg(string msg)
    {
        if (isAnimation)
        {
            msgText.text = targetMsg;
            CancelInvoke();
            EffectEnd();
        }
        else
        {
            targetMsg = msg;
            EffectStart();
        }
    }

    void EffectStart()
    {
        msgText.text = "";
        index = 0;
        EndCursor.SetActive(false);

        interval = 1.0f / CharPerSeconde;
        Debug.Log(interval);

        isAnimation = true;
        Invoke("Effecting", 1 / CharPerSeconde);

    }

    void Effectingt()
    {
        if(msgText.text == targetMsg)
        {
            EffectEnd();
            return;
        }

        msgText.text += targetMsg[index];

        if(targetMsg[index] != ' ' || targetMsg[index] != '.')
            audioSource.Play();

        index++;

        Invoke("Effecting", 1 / CharPerSeconde);
    }

    void EffectEnd()
    {
        isAnimation = false;
        EndCursor.SetActive(true);
    }
}
