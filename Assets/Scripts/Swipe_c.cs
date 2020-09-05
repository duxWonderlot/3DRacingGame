using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe_c : MonoBehaviour
{
    public bool tab, Swipe_left, Swipe_right, Swipe_up, Swipe_down;
    public bool isDragging = false;
    Vector2 Touch_Begin, Swipe_delta;
    public bool Tab_T { get { return tab; } }
    public bool swipe_left { get { return Swipe_left; } }
    public bool swipe_right { get { return Swipe_right; } }
    public bool swipe_up { get { return Swipe_up; } }
    public bool swipe_down { get { return Swipe_down; } }

    private void Update()
    {
        tab = Swipe_down = Swipe_up = Swipe_right = Swipe_left = false;
        #region Inputs
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            tab = true;
            Touch_Begin = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            Reset();
        }

        //calculate distance

        Swipe_delta = Vector2.zero;
        if (Touch_Begin != Vector2.zero)
        {
            if (isDragging)
            {
                if (Input.GetMouseButton(0))
                {
                    Swipe_delta = (Vector2)Input.mousePosition - Touch_Begin;
                }
            }

        }

        //deadzone
        if (Swipe_delta.magnitude > 125)
        {
            float x = Swipe_delta.x;
            float y = Swipe_delta.y;
            if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                if (x < 0)
                    Swipe_left = true;
                else
                    Swipe_right = true;
            }
            else
            {
                if (y < 0)
                    Swipe_down = true;
                else
                    Swipe_up = true;

            }

            Reset();
        }
        #endregion
    }
    private void Reset()
    {
        Touch_Begin = Swipe_delta = Vector2.zero;
    }
}
