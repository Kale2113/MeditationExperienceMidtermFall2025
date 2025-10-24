using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GazeButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Gaze Settings")]
    public float gazeTime = 2f; // seconds to trigger
    private float gazeTimer = 0f;
    private bool isGazing = false;

    [Header("Radial Progress bar")]
    public Image progressImage; // circular fill or bar to show progress

    [Header("Event")]
    public UnityEvent onGazeClick;

    void Update()
    {
        if (isGazing)
        {
            gazeTimer += Time.deltaTime;

            // Optional: show progress
            if (progressImage != null)
                progressImage.fillAmount = gazeTimer / gazeTime;

            if (gazeTimer >= gazeTime)
            {
                onGazeClick.Invoke();
                ResetGaze();
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isGazing = true;
        gazeTimer = 0f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ResetGaze();
    }

    private void ResetGaze()
    {
        isGazing = false;
        gazeTimer = 0f;
        if (progressImage != null)
            progressImage.fillAmount = 0f;
    }
}
