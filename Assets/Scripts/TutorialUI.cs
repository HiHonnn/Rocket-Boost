using System.Collections;
using UnityEngine;

public class TutorialUI : MonoBehaviour
{
    [SerializeField] GameObject tutorialPanel;
    [SerializeField] float displayTime = 3f;

    IEnumerator Start()
    {
        // Hiện panel khi bắt đầu game.
        tutorialPanel.SetActive(true);

        // Chờ 3 giây.
        yield return new WaitForSecondsRealtime(displayTime);

        // Ẩn panel.
        tutorialPanel.SetActive(false);
    }
}