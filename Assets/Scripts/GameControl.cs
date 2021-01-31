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
    List<Sprite> WordSprites = new List<Sprite>();

    List<string> Words = new List<string>();


    public Image centerWordImage, leftWordImage, rightWordImage, backgroundWordImage;
    public Sprite catSprite, dogSprite, bearSprite, frogSprite, goatSprite, duckSprite, snakeSprite, mouseSprite, horseSprite, tigerSprite, zebraSprite, lizardSprite, donkeySprite, monkeySprite, wolfSprite, batSprite, camelSprite, chickenSprite, dolphinSprite, sharkSprite, forestSprite;
    public Sprite motherSprite, sisterSprite, familySprite;

    public Animator fairyAnimator;

    void Start()
    {
        centerWordImage.preserveAspect = true;
        leftWordImage.preserveAspect = true;
        rightWordImage.preserveAspect = true;
        backgroundWordImage.preserveAspect = false;

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

    // void Update()
    public void UpdateStage()
    {
        // for (int h = 0; h < 3; h++)
        //  {


        Words.Clear();
        for (int i = 0; i < Row1.Count; i++)
        {
            // checking if first letters have been removed
            if (Row1[i].childCount > 0)
            {
                Words.Add(Row1[i].GetChild(0).gameObject.name);
            }

            // B ------------------------------
            // Bat ------------------------------

            // C ---------------------------------------
            if (Row1[i].childCount > 0 && Row1[i].GetChild(0).gameObject.name == "C")
            {
                if (Row1[i + 1].childCount > 0 && Row1[i + 1].GetChild(0).gameObject.name == "A")
                {
                    // Cat ------------------------------
                    if (Row1[i + 2].childCount > 0 && Row1[i + 2].GetChild(0).gameObject.name == "T")
                    {
                        if (!WordSprites.Contains(catSprite))
                        {
                            WordSprites.Add(catSprite);
                            continue;
                        }
                    }
                    else
                    {
                        if (WordSprites.Contains(catSprite))
                        {
                            WordSprites.Remove(catSprite);
                            continue;
                        }
                    }
                }
                else
                {
                    if (WordSprites.Contains(catSprite))
                    {
                        WordSprites.Remove(catSprite);
                        continue;
                    }
                }
            }
            else
            {
                // if none of them are c
                if (!Words.Contains("C"))
                {
                    WordSprites.Remove(catSprite);
                }
            }



            // D -------------------------------------
            // Dog ------------------------------
            if (Row1[i].childCount > 0 && Row1[i].GetChild(0).gameObject.name == "D")
            {

                if (Row1[i + 1].childCount > 0 && Row1[i + 1].GetChild(0).gameObject.name == "O")
                {
                    if (Row1[i + 2].childCount > 0 && Row1[i + 2].GetChild(0).gameObject.name == "G")
                    {
                        if (!WordSprites.Contains(dogSprite))
                        {
                            WordSprites.Add(dogSprite);
                            continue;
                        }
                    }
                    else
                    {
                        if (WordSprites.Contains(dogSprite))
                        {
                            WordSprites.Remove(dogSprite);
                            continue;
                        }
                    }
                }
                else
                {
                    if (WordSprites.Contains(dogSprite))
                    {
                        WordSprites.Remove(dogSprite);
                        continue;
                    }
                }
            }
            else
            {
                // if none of them are d
                if (!Words.Contains("D"))
                {
                    WordSprites.Remove(dogSprite);

                }
            }




        }

        print(WordSprites.Count);


        //RULES ----------------       

        if (WordSprites.Count > 1)
        {
            ClearImage(centerWordImage);
            AddImage(leftWordImage, WordSprites[0]);
            AddImage(rightWordImage, WordSprites[1]);
            // ClearImage(backgroundWordImage);
        }
        else if (WordSprites.Count == 1)
        {
            ClearImage(leftWordImage);
            ClearImage(rightWordImage);
            AddImage(centerWordImage, WordSprites[0]);
            // ClearImage(backgroundWordImage);
        }
        else
        {
            ClearImage(centerWordImage);
            ClearImage(leftWordImage);
            ClearImage(rightWordImage);
            // ClearImage(backgroundWordImage);
        }
    }
}