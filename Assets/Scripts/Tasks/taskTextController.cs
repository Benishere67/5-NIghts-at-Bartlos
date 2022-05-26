using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class taskTextController : MonoBehaviour
{
    public TMP_Text taskText;

    private float time;

    private bool timerDone = false;

    public static int taskNum = 1;

    // Update is called once per frame
    void Update() {
        if (time >= 5) {
            timerDone = true;
            time = 0;
        }

       /* if (taskNum == 1) {
            else {
                taskText.text = ("Throw away the trash");
            }
        }
        else if (taskNum == 2 && timerDone == true) {
            taskText.text = ("Do something else");
        }
        else {
            taskText.text = ("Go to next task");
        }
    }
*/
    }
    IEnumerator timer() {
        yield return new WaitForSecondsRealtime(5f);
        time += 5f;
        taskNum = 2;
    }
}
