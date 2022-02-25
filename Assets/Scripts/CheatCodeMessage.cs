using UnityEngine;

public class CheatCodeMessage : MonoBehaviour
{
    public KeyCode[] cheatCode;
    int index = 0;
    public GameObject message;

    void Update()
    {
        if (Input.anyKeyDown && index < cheatCode.Length)
        {
            if (Input.GetKeyDown(cheatCode[index]))
            {
                index++;
            }
            else
            {
                index = 0;
            }
        }

        if (index == cheatCode.Length)
        {
            message.SetActive(true);
        }
    }
}
