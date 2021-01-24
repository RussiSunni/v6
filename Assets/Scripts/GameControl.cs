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
    List<Sprite> Pictures = new List<Sprite>();


    public Image wordImage;
    public Sprite catSprite, dogSprite, bearSprite, frogSprite, goatSprite, duckSprite, snakeSprite, mouseSprite, horseSprite, tigerSprite, zebraSprite, lizardSprite, donkeySprite, monkeySprite;


    void Start()
    {
        wordImage.preserveAspect = true;

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
    }

    private void ClearPic()
    {
        var tempColor = wordImage.color;
        tempColor.a = 0f;
        wordImage.color = tempColor;
    }


    void Update()
    {
        //CAT
        //Row 1
        if ((Row1.Contains(C.parent) && Row1.Contains(A.parent) && Row1.Contains(T.parent) &&
        Row1[Row1.IndexOf(C.parent) + 1].GetChild(0).gameObject.name == "A" &&
        Row1[Row1.IndexOf(C.parent) + 2].GetChild(0).gameObject.name == "T")
             ||
        //    //Row 2
            (Row2.Contains(C.parent) && Row2.Contains(A.parent) && Row2.Contains(T.parent) &&
             Row2[Row2.IndexOf(C.parent) + 1].GetChild(0).gameObject.name == "A" &&
             Row2[Row2.IndexOf(C.parent) + 2].GetChild(0).gameObject.name == "T")
             ||
        //     //Row 3
             (Row3.Contains(C.parent) && Row3.Contains(A.parent) && Row3.Contains(T.parent) &&
             Row3[Row3.IndexOf(C.parent) + 1].GetChild(0).gameObject.name == "A" &&
             Row3[Row3.IndexOf(C.parent) + 2].GetChild(0).gameObject.name == "T"))
        {
            var tempColor = wordImage.color;
            tempColor.a = 1f;
            wordImage.color = tempColor;
            wordImage.sprite = catSprite;
        }
        else
        {
            var tempColor = wordImage.color;
            tempColor.a = 0f;
            wordImage.color = tempColor;
        }



        // if (Pictures.Count > 0)
        //     wordImage.sprite = Pictures[0];
        // else
        // {
        //     var tempColor = wordImage.color;
        //     tempColor.a = 0f;
        //     wordImage.color = tempColor;
        // }














    }



    // for (int i = 0; i < Col1.Count; i++)
    // {
    //     if (Col1[i].childCount > 0)
    //         for (int j = 0; j < Col2.Count; j++)
    //         {
    //             if (Col2[j].childCount > 0)
    //                 for (int k = 0; k < Col3.Count; k++)
    //                 {
    //                     if (Col3[k].childCount > 0)

    //                         if (Col1[i].GetChild(0).gameObject.name == "C" && Col2[i].GetChild(0).gameObject.name == "A" && Col3[i].GetChild(0).gameObject.name == "T")
    //                         {
    //                             var tempColor = wordImage.color;
    //                             tempColor.a = 1f;
    //                             wordImage.color = tempColor;
    //                             wordImage.sprite = catSprite;
    //                         }
    //                         else
    //                         {
    //                             var tempColor = wordImage.color;
    //                             tempColor.a = 0f;
    //                             wordImage.color = tempColor;
    //                         }
    //                 }
    //         }
    // }


    // if (D4.transform.GetChild(0).gameObject.name == "C" && E4.transform.GetChild(0).gameObject.name == "A" && F4.transform.GetChild(0).gameObject.name == "T")
    // {
    //     var tempColor = wordImage.color;
    //     tempColor.a = 1f;
    //     wordImage.color = tempColor;
    //     wordImage.sprite = catSprite;
    // }


    //     int wordPanel01LetterCount = wordPanel1.childCount;
    //     int wordPanel02LetterCount = wordPanel2.childCount;
    //     //print(letterCount);

    //     //Cat
    //     if (wordPanel01LetterCount == 3 && wordPanel1.transform.GetChild(0).gameObject.name == "C" && wordPanel1.transform.GetChild(1).gameObject.name == "A" && wordPanel1.transform.GetChild(2).gameObject.name == "T" ||
    //     wordPanel02LetterCount == 3 && wordPanel2.transform.GetChild(0).gameObject.name == "C" && wordPanel2.transform.GetChild(1).gameObject.name == "A" && wordPanel2.transform.GetChild(2).gameObject.name == "T"
    //     )
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = catSprite;

    //     }
    //     //Dog
    //     else if (wordPanel01LetterCount == 3 && wordPanel1.transform.GetChild(0).gameObject.name == "D" && wordPanel1.transform.GetChild(1).gameObject.name == "O" && wordPanel1.transform.GetChild(2).gameObject.name == "G")
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = dogSprite;
    //     }
    //     //Bear
    //     else if (wordPanel01LetterCount == 4 && wordPanel1.transform.GetChild(0).gameObject.name == "B" && wordPanel1.transform.GetChild(1).gameObject.name == "E" && wordPanel1.transform.GetChild(2).gameObject.name == "A" && wordPanel1.transform.GetChild(3).gameObject.name == "R")
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = bearSprite;
    //     }
    //     //Frog
    //     else if (wordPanel01LetterCount == 4 && wordPanel1.transform.GetChild(0).gameObject.name == "F" && wordPanel1.transform.GetChild(1).gameObject.name == "R" && wordPanel1.transform.GetChild(2).gameObject.name == "O" && wordPanel1.transform.GetChild(3).gameObject.name == "G")
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = frogSprite;
    //     }
    //     //Goat
    //     else if (wordPanel01LetterCount == 4 && wordPanel1.transform.GetChild(0).gameObject.name == "G" && wordPanel1.transform.GetChild(1).gameObject.name == "O" && wordPanel1.transform.GetChild(2).gameObject.name == "A" && wordPanel1.transform.GetChild(3).gameObject.name == "T")
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = goatSprite;
    //     }
    //     //Duck
    //     else if (wordPanel01LetterCount == 4 && wordPanel1.transform.GetChild(0).gameObject.name == "D" && wordPanel1.transform.GetChild(1).gameObject.name == "U" && wordPanel1.transform.GetChild(2).gameObject.name == "C" && wordPanel1.transform.GetChild(3).gameObject.name == "K")
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = duckSprite;
    //     }
    //     //Snake
    //     else if (wordPanel01LetterCount == 5 && wordPanel1.transform.GetChild(0).gameObject.name == "S" && wordPanel1.transform.GetChild(1).gameObject.name == "N" && wordPanel1.transform.GetChild(2).gameObject.name == "A" && wordPanel1.transform.GetChild(3).gameObject.name == "K" && wordPanel1.transform.GetChild(4).gameObject.name == "E")
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = snakeSprite;
    //     }
    //     //Mouse
    //     else if (wordPanel01LetterCount == 5 && wordPanel1.transform.GetChild(0).gameObject.name == "M" && wordPanel1.transform.GetChild(1).gameObject.name == "O" && wordPanel1.transform.GetChild(2).gameObject.name == "U" && wordPanel1.transform.GetChild(3).gameObject.name == "S" && wordPanel1.transform.GetChild(4).gameObject.name == "E")
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = mouseSprite;
    //     }
    //     //Horse
    //     else if (wordPanel01LetterCount == 5 && wordPanel1.transform.GetChild(0).gameObject.name == "H" && wordPanel1.transform.GetChild(1).gameObject.name == "O" && wordPanel1.transform.GetChild(2).gameObject.name == "R" && wordPanel1.transform.GetChild(3).gameObject.name == "S" && wordPanel1.transform.GetChild(4).gameObject.name == "E")
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = horseSprite;
    //     }
    //     //Tiger
    //     else if (wordPanel01LetterCount == 5 && wordPanel1.transform.GetChild(0).gameObject.name == "T" && wordPanel1.transform.GetChild(1).gameObject.name == "I" && wordPanel1.transform.GetChild(2).gameObject.name == "G" && wordPanel1.transform.GetChild(3).gameObject.name == "E" && wordPanel1.transform.GetChild(4).gameObject.name == "R")
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = tigerSprite;
    //     }
    //     //Zebra
    //     else if (wordPanel01LetterCount == 5 && wordPanel1.transform.GetChild(0).gameObject.name == "Z" && wordPanel1.transform.GetChild(1).gameObject.name == "E" && wordPanel1.transform.GetChild(2).gameObject.name == "B" && wordPanel1.transform.GetChild(3).gameObject.name == "R" && wordPanel1.transform.GetChild(4).gameObject.name == "A")
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = zebraSprite;
    //     }
    //     //Lizard
    //     else if (wordPanel01LetterCount == 6 && wordPanel1.transform.GetChild(0).gameObject.name == "L" && wordPanel1.transform.GetChild(1).gameObject.name == "I" && wordPanel1.transform.GetChild(2).gameObject.name == "Z" && wordPanel1.transform.GetChild(3).gameObject.name == "A" && wordPanel1.transform.GetChild(4).gameObject.name == "R" && wordPanel1.transform.GetChild(5).gameObject.name == "D")
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = lizardSprite;
    //     }
    //     //Donkey
    //     else if (wordPanel01LetterCount == 6 && wordPanel1.transform.GetChild(0).gameObject.name == "D" && wordPanel1.transform.GetChild(1).gameObject.name == "O" && wordPanel1.transform.GetChild(2).gameObject.name == "N" && wordPanel1.transform.GetChild(3).gameObject.name == "K" && wordPanel1.transform.GetChild(4).gameObject.name == "E" && wordPanel1.transform.GetChild(5).gameObject.name == "Y")
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = donkeySprite;
    //     }
    //     //Monkey
    //     else if (wordPanel01LetterCount == 6 && wordPanel1.transform.GetChild(0).gameObject.name == "M" && wordPanel1.transform.GetChild(1).gameObject.name == "O" && wordPanel1.transform.GetChild(2).gameObject.name == "N" && wordPanel1.transform.GetChild(3).gameObject.name == "K" && wordPanel1.transform.GetChild(4).gameObject.name == "E" && wordPanel1.transform.GetChild(5).gameObject.name == "Y")
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 1f;
    //         wordImage.color = tempColor;
    //         wordImage.sprite = monkeySprite;
    //     }
    //     else
    //     {
    //         var tempColor = wordImage.color;
    //         tempColor.a = 0f;
    //         wordImage.color = tempColor;
    //     }
    // }
}
