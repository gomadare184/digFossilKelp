using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel
{
    //表示されるパネルの情報
    public Panel()
    {
    }

    internal Panel(int x,int y,int panelHP)
    {
        this.x = x;
        this.y = y;
        this.panelHP = panelHP;
    }
    
    public int panelHP;
    public int x;
    public int y;
    public bool isUnderItem;
}
