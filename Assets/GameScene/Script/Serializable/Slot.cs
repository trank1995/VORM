using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Slot : System.Object {
    public int x { get; set; }
    public int y { get; set; }
    public Card curCard { get; set; }
    public List<Slot> neighbors { get; set; }
    public Slot (int ix, int iy)
    {
        x = ix;
        y = iy;
        neighbors = new List<Slot>();
    }

    public List<Slot> getAvailableSlots(int actionPoint)
    {
        List<Slot> result = new List<Slot>();
        if (actionPoint <= 0)
        {
            return result;
        }
        foreach (Slot s in neighbors)
        {
            if (s.curCard == null && actionPoint >= 1)
            {
                if (!result.Contains(s))
                {
                    result.Add(s);
                }
                result.AddRange(s.getAvailableSlots(actionPoint - 1));
            }
        }
        return result;
    }





    public void setNeighborFull(int maxX, int maxY)
    {
        for (int xi = x - 1; xi <= x + 1; xi++)
        {
            for (int yi = y - 1; yi <= y + 1; yi++)
            {
                if (xi != x || yi != y)
                {
                    if (xi >= 0 && xi < maxX && yi >= 0 && yi < maxY)
                    {
                        if (!neighbors.Contains(BoardManager.slotObjects[xi, yi].slot))
                        {
                            neighbors.Add(BoardManager.slotObjects[xi, yi].slot);
                            BoardManager.slotObjects[xi, yi].slot.neighbors.Add(this);
                        }
                    }
                }
            }
        }
    }

    public void setNeighborFourWay(int maxX, int maxY)
    {
        for (int xi = x-1; xi <= x+1; xi++)
        {
            for (int yi = y-1; yi <= y+1; yi++)
            {
                if (xi == x || yi == y)
                {
                    if (xi >= 0 && xi < maxX && yi >= 0 && yi < maxY)
                    {
                        if (!neighbors.Contains(BoardManager.slotObjects[xi, yi].slot))
                        {
                            neighbors.Add(BoardManager.slotObjects[xi, yi].slot);
                            BoardManager.slotObjects[xi, yi].slot.neighbors.Add(this);
                        }
                    }
                }
            }
        }
    }

    public void setNeighborRandom(int maxX, int maxY, int percentage)
    {
        for (int xi = x - 1; xi <= x + 1; xi++)
        {
            for (int yi = y - 1; yi <= y + 1; yi++)
            {
                if (xi != x || yi != y)
                {
                    if (xi >= 0 && xi < maxX && yi >= 0 && yi < maxY)
                    {
                        int r = Random.Range(1, 100);
                        if (r <= percentage)
                        {
                            if (!neighbors.Contains(BoardManager.slotObjects[xi, yi].slot))
                            {
                                neighbors.Add(BoardManager.slotObjects[xi, yi].slot);
                                BoardManager.slotObjects[xi, yi].slot.neighbors.Add(this);
                            }
                        }
                    }
                }
            }
        }
    }
}
