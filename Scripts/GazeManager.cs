using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GazeManager : MonoBehaviour
{
    [Header("Settings")]
    public float dwellTime = 2f;              
    
    private Button currentButton = null;
    private Button hitButton = null;

    void Update()
    {
        RaycastGaze();
        
    }

    void RaycastGaze()
    {
        Transform camera = Camera.main.transform;
        Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward);

        Debug.DrawRay(camera.position, camera.forward * 100f, Color.red);

        hitButton = null;

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            // The child collider must be tagged "Button"
            if (hit.transform.gameObject.CompareTag("Button"))
            {
                // Get the parent Button component (or in parents)
                hitButton = hit.transform.GetComponentInParent<Button>();
            }
        }

        if (currentButton != hitButton)
        {
            // Send pointer exit to old button
            if (currentButton != null)
                ExecuteEvents.Execute<IPointerExitHandler>(currentButton.gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerExitHandler);

            currentButton = hitButton;

            // Send pointer enter to new button
            if (currentButton != null)
                ExecuteEvents.Execute<IPointerEnterHandler>(currentButton.gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerEnterHandler);
        }

        // If no button is hit, send exit to current
        if (hitButton == null && currentButton != null)
        {
            ExecuteEvents.Execute<IPointerExitHandler>(currentButton.gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerExitHandler);
            currentButton = null;
        }
    }

   
}