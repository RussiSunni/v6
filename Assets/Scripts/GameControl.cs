using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    //public Transform wordPanel1, wordPanel2;
    public Transform A4, A5, A6, B4, B5, B6, C4, C5, C6, D4, D5, D6, E4, E5, E6, F4, F5, F6, G4, G5, G6, H4, H5, H6;
    public Transform A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z;
    List<Transform> Col1 = new List<Transform>();
    List<Transform> Col2 = new List<Transform>();
    List<Transform> Col3 = new List<Transform>();
    List<Transform> Row1 = new List<Transform>();
    List<Transform> Row2 = new List<Transform>();
    List<Transform> Row3 = new List<Transform>();
    List<List<Transform>> Rows = new List<List<Transform>>();
    public bool cat, dog, bear;

    List<string> Words = new List<string>();
    List<Sprite> WordSprites = new List<Sprite>();
    int numberWords;



    public Image centerWordImage, leftWordImage, rightWordImage;
    public Sprite catSprite, dogSprite, bearSprite, frogSprite, goatSprite, duckSprite, snakeSprite, mouseSprite, horseSprite, tigerSprite, zebraSprite, lizardSprite, donkeySprite, monkeySprite;


    void Start()
    {
        centerWordImage.preserveAspect = true;
        leftWordImage.preserveAspect = true;
        rightWordImage.preserveAspect = true;

        Col1.Add(A4);
        Col1.Add(A5);
        Col1.Add(A6);

        Col2.Add(B4);
        Col2.Add(B5);
        Col2.Add(B6);

        Col3.Add(C4);
        Col3.Add(C5);
        Col3.Add(C6);

        Row1.Add(A4);
        Row1.Add(B4);
        Row1.Add(C4);
        Row1.Add(D4);
        Row1.Add(E4);
        Row1.Add(F4);
        Row1.Add(G4);
        Row1.Add(H4);

        Row2.Add(A5);
        Row2.Add(B5);
        Row2.Add(C5);
        Row2.Add(D5);
        Row2.Add(E5);
        Row2.Add(F5);
        Row2.Add(G5);
        Row2.Add(H5);

        Row3.Add(A6);
        Row3.Add(B6);
        Row3.Add(C6);
        Row3.Add(D6);
        Row3.Add(E6);
        Row3.Add(F6);
        Row3.Add(G6);
        Row3.Add(H6);

        Rows.Add(Row1);
        Rows.Add(Row2);
        Rows.Add(Row3);
    }

    private void ClearImage(Image image)
    {
        var tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;
    }

    private void AddImage(Image image, Sprite sprite)
    {
        var tempColor = image.color;
        tempColor.a = 1f;
        image.color = tempColor;
        image.sprite = sprite;
    }

    void Update()
    {
        //CAT
        //Row 1
        if ((Row1.Contains(C.parent) && Row1.Contains(A.parent) && Row1.Contains(T.parent) &&
        Row1[Row1.IndexOf(C.parent) + 1].GetChild(0).gameObject.name == "A" &&
        Row1[Row1.IndexOf(C.parent) + 2].GetChild(0).gameObject.name == "T")
             ||
            //Row 2
            (Row2.Contains(C.parent) && Row2.Contains(A.parent) && Row2.Contains(T.parent) &&
             Row2[Row2.IndexOf(C.parent) + 1].GetChild(0).gameObject.name == "A" &&
             Row2[Row2.IndexOf(C.parent) + 2].GetChild(0).gameObject.name == "T")
             ||
             //Row 3
             (Row3.Contains(C.parent) && Row3.Contains(A.parent) && Row3.Contains(T.parent) &&
             Row3[Row3.IndexOf(C.parent) + 1].GetChild(0).gameObject.name == "A" &&
             Row3[Row3.IndexOf(C.parent) + 2].GetChild(0).gameObject.name == "T"))
        {
            cat = true;
            if (!Words.Contains("cat"))
                Words.Add("cat");

            if (!WordSprites.Contains(catSprite))
                WordSprites.Add(catSprite);
        }
        else
        {
            cat = false;
            Words.Remove("cat");
            WordSprites.Remove(catSprite);
        }

        //DOG
        //Row 1
        if ((Row1.Contains(D.parent) && Row1.Contains(O.parent) && Row1.Contains(G.parent) &&
        Row1[Row1.IndexOf(D.parent) + 1].GetChild(0).gameObject.name == "O" &&
        Row1[Row1.IndexOf(D.parent) + 2].GetChild(0).gameObject.name == "G")
             ||
            //Row 2
            (Row2.Contains(D.parent) && Row2.Contains(O.parent) && Row2.Contains(G.parent) &&
             Row2[Row2.IndexOf(D.parent) + 1].GetChild(0).gameObject.name == "O" &&
             Row2[Row2.IndexOf(D.parent) + 2].GetChild(0).gameObject.name == "G")
             ||
             //Row 3
             (Row3.Contains(D.parent) && Row3.Contains(O.parent) && Row3.Contains(G.parent) &&
             Row3[Row3.IndexOf(D.parent) + 1].GetChild(0).gameObject.name == "O" &&
             Row3[Row3.IndexOf(D.parent) + 2].GetChild(0).gameObject.name == "G"))
        {
            dog = true;
            if (!Words.Contains("dog"))
            {
                Words.Add("dog");
            }
            if (!WordSprites.Contains(dogSprite))
                WordSprites.Add(dogSprite);
        }
        else
        {
            dog = false;
            Words.Remove("dog");
            WordSprites.Remove(dogSprite);
        }

        //BEAR
        for (int i = 0; i < 3; i++)
        {
            if ((Rows[i].Contains(B.parent) && Rows[i].Contains(E.parent) && Rows[i].Contains(A.parent) && Rows[i].Contains(R.parent) &&
            Rows[i][Rows[i].IndexOf(B.parent) + 1].GetChild(0).gameObject.name == "E" &&
             Rows[i][Rows[i].IndexOf(B.parent) + 2].GetChild(0).gameObject.name == "A" &&
            Rows[i][Rows[i].IndexOf(B.parent) + 3].GetChild(0).gameObject.name == "R"))
            {
                bear = true;
                if (!Words.Contains("bear"))
                    Words.Add("bear");

                if (!WordSprites.Contains(bearSprite))
                    WordSprites.Add(bearSprite);

                break;
            }
            else
            {
                bear = false;
                Words.Remove("bear");
                WordSprites.Remove(bearSprite);
            }
        }


        //RULES ----------------       

        if (WordSprites.Count > 1)
        {
            ClearImage(centerWordImage);
            AddImage(leftWordImage, WordSprites[0]);
            AddImage(rightWordImage, WordSprites[1]);
        }
        else if (WordSprites.Count == 1)
        {
            ClearImage(leftWordImage);
            ClearImage(rightWordImage);
            AddImage(centerWordImage, WordSprites[0]);
        }
        else
        {
            ClearImage(centerWordImage);
            ClearImage(leftWordImage);
            ClearImage(rightWordImage);
        }
    }
}