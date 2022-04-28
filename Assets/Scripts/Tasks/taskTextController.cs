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

    public static int taskNum;

    // Update is called once per frame
    void Update() {
        if (time >= 3) {
            timerDone = true;
        }

        if (taskNum == 1) {
            if (Task1.taskDone == true) {
                taskText.text = ("Task Completed!");
                Debug.Log("task 1 = slayed");
                StartCoroutine(timer());
                taskNum = 2;
            }
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

    IEnumerator timer() {
        yield return new WaitForSecondsRealtime(3f);
        time += 3f;
    }
}
