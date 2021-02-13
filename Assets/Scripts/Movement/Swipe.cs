using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Required when using Event data.

public class Swipe : MonoBehaviour, IPointerDownHandler, IPointerUpHandler // required interface when using the OnPointerDown method.
{
    GameObject block;
    private Vector3 firstTouchPosition;
    private Vector3 finalTouchPosition;
    float swipeAngle = 0;
    Transform B4;

    void Start()
    {
        block = this.gameObject;
        B4 = GameObject.Find("B4").transform;
    }

    // UI elements
    public void OnPointerDown(PointerEventData eventData)
    {
        var mousePos = Input.mousePosition;
        firstTouchPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.8f));
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        finalTouchPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.8f));
        CalculateAngle();
    }

    void CalculateAngle()
    {
        swipeAngle = Mathf.Atan2(finalTouchPosition.y - firstTouchPosition.y, finalTouchPosition.x - firstTouchPosition.x) * 180 / Mathf.PI;
        MovePieces();
    }

    // ui
    void MovePieces()
    {
        // column and row

        var gameControl = GameObject.Find("GameControl");
        GameControl gameControlScript = gameControl.GetComponent<GameControl>();
        var parent = block.transform.parent;

        if (gameControlScript.Row1.Contains(parent))
        {
            var parentRow = gameControlScript.Row1;
        }
        else if (gameControlScript.Row2.Contains(parent))
        {
            var parentRow = gameControlScript.Row2;
        }

        int parentIndex = gameControlScript.Row1.IndexOf(parent);

        if (swipeAngle > -45 && swipeAngle <= 45)
        {
            //  Debug.Log("right");
            var newParentIndex = parentIndex + 1;
            this.transform.SetParent(gameControlScript.Row1[newParentIndex]);
        }
        else if (swipeAngle > 45 && swipeAngle <= 135)
        {
            Debug.Log("up");
        }
        else if (swipeAngle > 135 || swipeAngle <= -135)
        {
            //  Debug.Log("left");
            var newParentIndex = parentIndex - 1;
            this.transform.SetParent(gameControlScript.Row1[newParentIndex]);
        }
        else if (swipeAngle < -45 && swipeAngle >= -135)
        {
            Debug.Log("down");

            // this.transform.SetParent(hand);

        }
        StartCoroutine((RegisterWord()));
    }
    IEnumerator RegisterWord()
    {
        yield return new WaitForSeconds(0.1f);

        GameObject gameControl = GameObject.Find("GameControl");
        GameControl gameControlScript = gameControl.GetComponent<GameControl>();
        gameControlScript.UpdateStage();
    }
}
