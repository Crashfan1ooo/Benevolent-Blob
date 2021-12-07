using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIDrag : MonoBehaviour,IDragHandler
{
    Vector2 currentPos;
    Vector3 newPos;
    RectTransform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = RectTransformUtility.WorldToScreenPoint(new Camera(), transform.position);
        currentPos.x = Mathf.Clamp(currentPos.x, tr.sizeDelta.x/2f, Screen.width- tr.sizeDelta.x / 2f);
        currentPos.y = Mathf.Clamp(currentPos.y, tr.sizeDelta.y/2f, Screen.height- tr.sizeDelta.y /2f);
        RectTransformUtility.ScreenPointToWorldPointInRectangle(tr, currentPos, new Camera(), out newPos);
        transform.position = newPos;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
}
