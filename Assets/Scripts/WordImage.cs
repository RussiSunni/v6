using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordImage : MonoBehaviour
{
    public string wordName;
    public Sprite imageSprite;
    public Sprite catSprite, dogSprite, bearSprite, frogSprite, goatSprite, duckSprite, snakeSprite, mouseSprite, horseSprite, tigerSprite, zebraSprite, lizardSprite, donkeySprite, monkeySprite, wolfSprite, batSprite, camelSprite, chickenSprite, dolphinSprite, sharkSprite, forestSprite;

    public wordImage(string wordName, Sprite imageSprite)
    {
        this.wordName = wordName;
        this.imageSprite = imageSprite;
    }

    void Main(string[] args)
    {
        wordImage cat = new wordImage("CAT", catSprite);
    }

}