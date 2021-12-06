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
        currentPos.x = Mathf.Clamp(currentPos.x, 0, Screen.width);
        currentPos.y = Mathf.Clamp(currentPos.y, 0, Screen.height);
        RectTransformUtility.ScreenPointToWorldPointInRectangle(tr, currentPos, new Camera(), out newPos);
        transform.position = newPos;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
}
