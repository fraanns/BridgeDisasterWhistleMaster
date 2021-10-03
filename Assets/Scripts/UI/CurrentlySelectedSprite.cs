using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CurrentlySelectedSprite : MonoBehaviour
{
    public float smooth = 0.3f;

    RectTransform rectTransform;

    Image spriteRenderer;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        spriteRenderer = GetComponent<Image>();
    }

    void Update()
    {
        GameObject go = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;

        if (go == null)
        {
            spriteRenderer.color = Color.Lerp(spriteRenderer.color, Color.clear, smooth * Time.deltaTime);
            //spriteRenderer.enabled = false;
            return;
        }
        else
        {
            //spriteRenderer.enabled = true;
            spriteRenderer.color = Color.Lerp(spriteRenderer.color, Color.white, smooth * Time.deltaTime);
        }

        RectTransform currentlySelected = go.GetComponent<RectTransform>();

        rectTransform.pivot = Vector2.Lerp(rectTransform.pivot, currentlySelected.pivot, smooth * Time.deltaTime);
        rectTransform.position = Vector3.Lerp(rectTransform.position, currentlySelected.position, smooth * Time.deltaTime);
        rectTransform.sizeDelta = Vector2.Lerp(rectTransform.sizeDelta, currentlySelected.sizeDelta, smooth * Time.deltaTime);
    }
}
