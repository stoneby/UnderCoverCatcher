using System.Collections;
using UnityEngine;

class GUIUtility
{
    public static object SelectList(ICollection list, object selected, GUIStyle defaultStyle, GUIStyle selectedStyle)
    {
        foreach (var item in list)
        {
            if (GUILayout.Button(item.ToString(), (selected == item) ? selectedStyle : defaultStyle))
            {
                if (selected == item)
                {
                    selected = null;
                }
                else
                {
                    selected = item;
                }
            }
        }

        return selected;
    }

    public delegate bool OnListItemGUI(object item, bool selected, ICollection list);

    public static object SelectList(ICollection list, object selected, OnListItemGUI itemHandler)
    {
        ArrayList itemList;

        itemList = new ArrayList(list);

        foreach (object item in itemList)
        {
            if (itemHandler(item, item == selected, list))
            {
                selected = item;
            }
            else if (selected == item)
            // If we *were* selected, but aren't any more then deselect
            {
                selected = null;
            }
        }

        return selected;
    }
}
