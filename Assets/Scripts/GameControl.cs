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


    public Image centerWordImage, leftWordImage, rightWordImage, backgroundWordImage;
    public Sprite catSprite, dogSprite, bearSprite, frogSprite, goatSprite, duckSprite, snakeSprite, mouseSprite, horseSprite, tigerSprite, zebraSprite, lizardSprite, donkeySprite, monkeySprite, wolfSprite, forestSprite;


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

    void Update()
    {

        // if there are blocks together
        for (int h = 0; h < 3; h++)
        {
            for (int i = 0; i < Rows[h].Count; i++)
            {
                if (Rows[h][i].childCount > 0)
                {
                    if (Rows[h][i + 1].childCount > 0)
                    {
                        if (Rows[h][i + 2].childCount > 0)
                        {
                            if (Rows[h][i].GetChild(0).gameObject.name == "A")
                            {

                            }
                            else if (Rows[h][i].GetChild(0).gameObject.name == "B")
                            {

                                if (Rows[h][i + 1].GetChild(0).gameObject.name == "E")
                                {
                                    if (Rows[h][i + 2].GetChild(0).gameObject.name == "A")
                                    {
                                        if (Rows[h][i + 3].childCount > 0 && Rows[h][i + 3].GetChild(0).gameObject.name == "R")
                                        {
                                            if (!WordSprites.Contains(bearSprite))
                                                WordSprites.Add(bearSprite);
                                            break;
                                        }
                                        else
                                        {
                                            WordSprites.Remove(bearSprite);
                                        }
                                    }
                                    else
                                        WordSprites.Clear();
                                }
                                else
                                    WordSprites.Clear();
                            }

                            else if (Rows[h][i].GetChild(0).gameObject.name == "C")
                            {
                                if (Rows[h][i + 1].GetChild(0).gameObject.name == "A")
                                {
                                    if (Rows[h][i + 2].GetChild(0).gameObject.name == "T")
                                    {
                                        if (!WordSprites.Contains(catSprite))
                                            WordSprites.Add(catSprite);
                                        break;
                                    }
                                    else
                                    {
                                        WordSprites.Remove(catSprite);
                                    }
                                }

                            }
                            // D -------------------------------------
                            else if (Rows[h][i].GetChild(0).gameObject.name == "D")
                            {
                                if (Rows[h][i + 1].GetChild(0).gameObject.name == "O")
                                {
                                    if (Rows[h][i + 2].GetChild(0).gameObject.name == "G")
                                    {
                                        if (!WordSprites.Contains(dogSprite))
                                            WordSprites.Add(dogSprite);
                                        break;
                                    }
                                    else
                                    {
                                        WordSprites.Remove(dogSprite);
                                    }
                                    if (Rows[h][i + 1].GetChild(0).gameObject.name == "O")
                                    {
                                        if (Rows[h][i + 2].GetChild(0).gameObject.name == "N")
                                        {
                                            if (Rows[h][i + 3].childCount > 0 && Rows[h][i + 3].GetChild(0).gameObject.name == "K")
                                            {
                                                if (Rows[h][i + 4].childCount > 0 && Rows[h][i + 4].GetChild(0).gameObject.name == "E")
                                                {
                                                    if (Rows[h][i + 5].childCount > 0 && Rows[h][i + 5].GetChild(0).gameObject.name == "Y")
                                                    {
                                                        if (!WordSprites.Contains(donkeySprite))
                                                            WordSprites.Add(donkeySprite);
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        WordSprites.Remove(donkeySprite);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (Rows[h][i + 1].GetChild(0).gameObject.name == "U")
                                {
                                    if (Rows[h][i + 2].GetChild(0).gameObject.name == "C")
                                    {
                                        if (Rows[h][i + 3].childCount > 0 && Rows[h][i + 3].GetChild(0).gameObject.name == "K")
                                        {
                                            if (!WordSprites.Contains(duckSprite))
                                                WordSprites.Add(duckSprite);
                                            break;
                                        }
                                        else
                                        {
                                            WordSprites.Remove(duckSprite);
                                        }
                                    }
                                }
                            }
                            //F ----------------------------------
                            else if (Rows[h][i].GetChild(0).gameObject.name == "F")
                            {
                                if (Rows[h][i + 1].GetChild(0).gameObject.name == "O")
                                {
                                    if (Rows[h][i + 2].GetChild(0).gameObject.name == "R")
                                    {
                                        if (Rows[h][i + 3].childCount > 0 && Rows[h][i + 3].GetChild(0).gameObject.name == "E")
                                        {
                                            if (Rows[h][i + 4].childCount > 0 && Rows[h][i + 4].GetChild(0).gameObject.name == "S")
                                            {
                                                if (Rows[h][i + 5].childCount > 0 && Rows[h][i + 5].GetChild(0).gameObject.name == "T")
                                                {
                                                    var tempColor = backgroundWordImage.color;
                                                    tempColor.a = 1f;
                                                    backgroundWordImage.color = tempColor;
                                                    backgroundWordImage.sprite = forestSprite;
                                                    break;
                                                }
                                                else
                                                {
                                                    var tempColor = backgroundWordImage.color;
                                                    tempColor.a = 0f;
                                                    backgroundWordImage.color = tempColor;
                                                }
                                            }
                                        }
                                    }
                                    else
                                        WordSprites.Clear();
                                }
                                else
                                    WordSprites.Clear();

                                if (Rows[h][i + 1].GetChild(0).gameObject.name == "R")
                                {
                                    if (Rows[h][i + 2].GetChild(0).gameObject.name == "O")
                                    {
                                        if (Rows[h][i + 3].childCount > 0 && Rows[h][i + 3].GetChild(0).gameObject.name == "G")
                                        {
                                            if (!WordSprites.Contains(frogSprite))
                                                WordSprites.Add(frogSprite);
                                            break;
                                        }
                                        else
                                        {
                                            WordSprites.Remove(frogSprite);
                                        }
                                    }
                                    else
                                        WordSprites.Clear();
                                }
                                else
                                    WordSprites.Clear();
                            }

                            // G ----------------------------------
                            else if (Rows[h][i].GetChild(0).gameObject.name == "G")
                            {
                                if (Rows[h][i + 1].GetChild(0).gameObject.name == "O")
                                {
                                    if (Rows[h][i + 2].GetChild(0).gameObject.name == "A")
                                    {
                                        if (Rows[h][i + 3].childCount > 0 && Rows[h][i + 3].GetChild(0).gameObject.name == "T")
                                        {
                                            if (!WordSprites.Contains(goatSprite))
                                                WordSprites.Add(goatSprite);
                                            break;
                                        }
                                        else
                                        {
                                            WordSprites.Remove(goatSprite);
                                        }
                                    }
                                }
                            }

                            // L ----------------------------------
                            else if (Rows[h][i].GetChild(0).gameObject.name == "L")
                            {
                                if (Rows[h][i + 1].childCount > 0 && Rows[h][i + 1].GetChild(0).gameObject.name == "I")
                                {
                                    if (Rows[h][i + 2].childCount > 0 && Rows[h][i + 2].GetChild(0).gameObject.name == "Z")
                                    {
                                        if (Rows[h][i + 3].childCount > 0 && Rows[h][i + 3].GetChild(0).gameObject.name == "A")
                                        {
                                            if (Rows[h][i + 4].childCount > 0 && Rows[h][i + 4].GetChild(0).gameObject.name == "R")
                                            {
                                                if (Rows[h][i + 5].childCount > 0 && Rows[h][i + 5].GetChild(0).gameObject.name == "D")
                                                {
                                                    if (!WordSprites.Contains(lizardSprite))
                                                        WordSprites.Add(lizardSprite);
                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                WordSprites.Remove(lizardSprite);
                                            }
                                        }
                                        else
                                            WordSprites.Clear();
                                    }
                                    else
                                        WordSprites.Clear();
                                }
                                else
                                    WordSprites.Clear();
                            }


                            // M -----------------------------------------                       
                            else if (Rows[h][i].GetChild(0).gameObject.name == "M")
                            {
                                if (Rows[h][i + 1].childCount > 0 && Rows[h][i + 1].GetChild(0).gameObject.name == "O")
                                {
                                    if (Rows[h][i + 2].childCount > 0 && Rows[h][i + 2].GetChild(0).gameObject.name == "U")
                                    {
                                        if (Rows[h][i + 3].childCount > 0 && Rows[h][i + 3].GetChild(0).gameObject.name == "S")
                                        {
                                            if (Rows[h][i + 4].childCount > 0 && Rows[h][i + 4].GetChild(0).gameObject.name == "E")
                                            {
                                                if (!WordSprites.Contains(mouseSprite))
                                                    WordSprites.Add(mouseSprite);
                                                break;
                                            }
                                            else
                                            {
                                                WordSprites.Remove(mouseSprite);
                                            }
                                        }
                                        else
                                            WordSprites.Clear();
                                    }
                                    else
                                        WordSprites.Clear();
                                }
                                else
                                    WordSprites.Clear();
                            }


                            // S -----------------------------------------                       
                            else if (Rows[h][i].GetChild(0).gameObject.name == "S")
                            {
                                if (Rows[h][i + 1].childCount > 0 && Rows[h][i + 1].GetChild(0).gameObject.name == "N")
                                {
                                    if (Rows[h][i + 2].childCount > 0 && Rows[h][i + 2].GetChild(0).gameObject.name == "A")
                                    {
                                        if (Rows[h][i + 3].childCount > 0 && Rows[h][i + 3].GetChild(0).gameObject.name == "K")
                                        {
                                            if (Rows[h][i + 4].childCount > 0 && Rows[h][i + 4].GetChild(0).gameObject.name == "E")
                                            {
                                                if (!WordSprites.Contains(snakeSprite))
                                                    WordSprites.Add(snakeSprite);
                                                break;
                                            }
                                            else
                                            {
                                                WordSprites.Remove(snakeSprite);
                                            }
                                        }
                                        else
                                            WordSprites.Clear();
                                    }
                                    else
                                        WordSprites.Clear();
                                }
                                else
                                    WordSprites.Clear();
                            }


                            // T ----------------------------------
                            else if (Rows[h][i].GetChild(0).gameObject.name == "T")
                            {
                                if (Rows[h][i + 1].childCount > 0 && Rows[h][i + 1].GetChild(0).gameObject.name == "I")
                                {
                                    if (Rows[h][i + 2].childCount > 0 && Rows[h][i + 2].GetChild(0).gameObject.name == "G")
                                    {
                                        if (Rows[h][i + 3].childCount > 0 && Rows[h][i + 3].GetChild(0).gameObject.name == "E")
                                        {
                                            if (Rows[h][i + 4].childCount > 0 && Rows[h][i + 4].GetChild(0).gameObject.name == "R")
                                            {
                                                if (!WordSprites.Contains(tigerSprite))
                                                    WordSprites.Add(tigerSprite);
                                                break;
                                            }
                                            else
                                            {
                                                WordSprites.Remove(tigerSprite);
                                            }
                                        }
                                        else
                                            WordSprites.Clear();
                                    }
                                    else
                                        WordSprites.Clear();
                                }
                                else
                                    WordSprites.Clear();
                            }

                            // W ----------------------
                            else if (Rows[h][i].GetChild(0).gameObject.name == "W")
                            {
                                if (Rows[h][i + 1].GetChild(0).gameObject.name == "O")
                                {
                                    if (Rows[h][i + 2].GetChild(0).gameObject.name == "L")
                                    {
                                        if (Rows[h][i + 3].childCount > 0 && Rows[h][i + 3].GetChild(0).gameObject.name == "F")
                                        {
                                            if (!WordSprites.Contains(wolfSprite))
                                                WordSprites.Add(wolfSprite);
                                            break;
                                        }
                                        else
                                        {
                                            WordSprites.Remove(wolfSprite);
                                        }
                                    }
                                }
                            }

                            // Z -----------------------
                            else if (Rows[h][i].GetChild(0).gameObject.name == "Z")
                            {
                                if (Rows[h][i + 1].childCount > 0 && Rows[h][i + 1].GetChild(0).gameObject.name == "E")
                                {
                                    if (Rows[h][i + 2].childCount > 0 && Rows[h][i + 2].GetChild(0).gameObject.name == "B")
                                    {
                                        if (Rows[h][i + 3].childCount > 0 && Rows[h][i + 3].GetChild(0).gameObject.name == "R")
                                        {
                                            if (Rows[h][i + 4].childCount > 0 && Rows[h][i + 4].GetChild(0).gameObject.name == "A")
                                            {
                                                if (!WordSprites.Contains(zebraSprite))
                                                    WordSprites.Add(zebraSprite);
                                                break;
                                            }
                                            else
                                            {
                                                WordSprites.Remove(zebraSprite);
                                            }
                                        }
                                        else
                                            WordSprites.Clear();
                                    }
                                    else
                                        WordSprites.Clear();
                                }
                                else
                                    WordSprites.Clear();
                            }




                            else
                                WordSprites.Clear();
                        }
                        else
                            WordSprites.Clear();
                    }
                    else
                        WordSprites.Clear();
                }
            }
        }


        // what is first block?





        //WORDS --------------
        //CAT
        // for (int i = 0; i < 3; i++)
        // {
        //     if ((Rows[i].Contains(C.parent) && Rows[i].Contains(A.parent) && Rows[i].Contains(T.parent) &&
        //     Rows[i][Rows[i].IndexOf(C.parent) + 1].GetChild(0).gameObject.name == "A" &&
        //      Rows[i][Rows[i].IndexOf(C.parent) + 2].GetChild(0).gameObject.name == "T"))
        //     {
        //         if (!WordSprites.Contains(catSprite))
        //             WordSprites.Add(catSprite);
        //         break;
        //     }
        //     else
        //     {
        //         WordSprites.Remove(catSprite);
        //     }
        // }

        //DOG
        // for (int i = 0; i < 3; i++)
        // {
        //     if ((Rows[i].Contains(D.parent) && Rows[i].Contains(O.parent) && Rows[i].Contains(G.parent) &&
        //     Rows[i][Rows[i].IndexOf(D.parent) + 1].GetChild(0).gameObject.name == "O" &&
        //      Rows[i][Rows[i].IndexOf(D.parent) + 2].GetChild(0).gameObject.name == "G"))
        //     {
        //         if (!WordSprites.Contains(dogSprite))
        //             WordSprites.Add(dogSprite);
        //         break;
        //     }
        //     else
        //     {
        //         WordSprites.Remove(dogSprite);
        //     }
        // }

        //BEAR
        // for (int i = 0; i < 3; i++)
        // {
        //     if ((Rows[i].Contains(B.parent) && Rows[i].Contains(E.parent) && Rows[i].Contains(A.parent) && Rows[i].Contains(R.parent) &&
        //     Rows[i][Rows[i].IndexOf(B.parent) + 1].GetChild(0).gameObject.name == "E" &&
        //      Rows[i][Rows[i].IndexOf(B.parent) + 2].GetChild(0).gameObject.name == "A" &&
        //     Rows[i][Rows[i].IndexOf(B.parent) + 3].GetChild(0).gameObject.name == "R"))
        //     {
        //         if (!WordSprites.Contains(bearSprite))
        //             WordSprites.Add(bearSprite);
        //         break;
        //     }
        //     else
        //     {
        //         WordSprites.Remove(bearSprite);
        //     }
        // }

        //FROG
        // for (int i = 0; i < 3; i++)
        // {
        //     if ((Rows[i].Contains(F.parent) && Rows[i].Contains(R.parent) && Rows[i].Contains(O.parent) && Rows[i].Contains(G.parent) &&
        //     Rows[i][Rows[i].IndexOf(F.parent) + 1].GetChild(0).gameObject.name == "R" &&
        //      Rows[i][Rows[i].IndexOf(F.parent) + 2].GetChild(0).gameObject.name == "O" &&
        //     Rows[i][Rows[i].IndexOf(F.parent) + 3].GetChild(0).gameObject.name == "G"))
        //     {
        //         if (!WordSprites.Contains(frogSprite))
        //             WordSprites.Add(frogSprite);
        //         break;
        //     }
        //     else
        //     {
        //         WordSprites.Remove(frogSprite);
        //     }
        // }

        // //DUCK
        // for (int i = 0; i < 3; i++)
        // {
        //     if ((Rows[i].Contains(D.parent) && Rows[i].Contains(U.parent) && Rows[i].Contains(C.parent) && Rows[i].Contains(K.parent) &&
        //     Rows[i][Rows[i].IndexOf(D.parent) + 1].GetChild(0).gameObject.name == "U" &&
        //      Rows[i][Rows[i].IndexOf(D.parent) + 2].GetChild(0).gameObject.name == "C" &&
        //     Rows[i][Rows[i].IndexOf(D.parent) + 3].GetChild(0).gameObject.name == "K"))
        //     {
        //         if (!WordSprites.Contains(duckSprite))
        //             WordSprites.Add(duckSprite);
        //         break;
        //     }
        //     else
        //     {
        //         WordSprites.Remove(duckSprite);
        //     }
        // }

        // //DONKEY
        // for (int i = 0; i < 3; i++)
        // {
        //     if ((Rows[i].Contains(D.parent) && Rows[i].Contains(O.parent) && Rows[i].Contains(N.parent) && Rows[i].Contains(K.parent) && Rows[i].Contains(E.parent) && Rows[i].Contains(Y.parent) &&
        //     Rows[i][Rows[i].IndexOf(D.parent) + 1].GetChild(0).gameObject.name == "O" &&
        //      Rows[i][Rows[i].IndexOf(D.parent) + 2].GetChild(0).gameObject.name == "N" &&
        //     Rows[i][Rows[i].IndexOf(D.parent) + 3].GetChild(0).gameObject.name == "K" &&
        //     Rows[i][Rows[i].IndexOf(D.parent) + 4].GetChild(0).gameObject.name == "E" &&
        //     Rows[i][Rows[i].IndexOf(D.parent) + 5].GetChild(0).gameObject.name == "Y"))
        //     {
        //         if (!WordSprites.Contains(donkeySprite))
        //             WordSprites.Add(donkeySprite);
        //         break;
        //     }
        //     else
        //     {
        //         WordSprites.Remove(donkeySprite);
        //     }
        // }

        // //TIGER
        // for (int i = 0; i < 3; i++)
        // {
        //     if ((Rows[i].Contains(D.parent) && Rows[i].Contains(O.parent) && Rows[i].Contains(N.parent) && Rows[i].Contains(K.parent) && Rows[i].Contains(E.parent) && Rows[i].Contains(Y.parent) &&
        //     Rows[i][Rows[i].IndexOf(D.parent) + 1].GetChild(0).gameObject.name == "O" &&
        //      Rows[i][Rows[i].IndexOf(D.parent) + 2].GetChild(0).gameObject.name == "N" &&
        //     Rows[i][Rows[i].IndexOf(D.parent) + 3].GetChild(0).gameObject.name == "K" &&
        //     Rows[i][Rows[i].IndexOf(D.parent) + 4].GetChild(0).gameObject.name == "E" &&
        //     Rows[i][Rows[i].IndexOf(D.parent) + 5].GetChild(0).gameObject.name == "Y"))
        //     {
        //         if (!WordSprites.Contains(donkeySprite))
        //             WordSprites.Add(donkeySprite);
        //         break;
        //     }
        //     else
        //     {
        //         WordSprites.Remove(donkeySprite);
        //     }
        // }


        // //FOREST
        // for (int i = 0; i < 3; i++)
        // {
        //     if ((Rows[i].Contains(F.parent) && Rows[i].Contains(O.parent) && Rows[i].Contains(R.parent) && Rows[i].Contains(E.parent) && Rows[i].Contains(S.parent) && Rows[i].Contains(T.parent) &&
        //     Rows[i][Rows[i].IndexOf(F.parent) + 1].GetChild(0).gameObject.name == "O" &&
        //      Rows[i][Rows[i].IndexOf(F.parent) + 2].GetChild(0).gameObject.name == "R" &&
        //     Rows[i][Rows[i].IndexOf(F.parent) + 3].GetChild(0).gameObject.name == "E" &&
        //     Rows[i][Rows[i].IndexOf(F.parent) + 4].GetChild(0).gameObject.name == "S" &&
        //     Rows[i][Rows[i].IndexOf(F.parent) + 5].GetChild(0).gameObject.name == "T"))
        //     {
        //         var tempColor = backgroundWordImage.color;
        //         tempColor.a = 1f;
        //         backgroundWordImage.color = tempColor;
        //         backgroundWordImage.sprite = forestSprite;
        //         break;
        //     }
        //     else
        //     {
        //         var tempColor = backgroundWordImage.color;
        //         tempColor.a = 0f;
        //         backgroundWordImage.color = tempColor;
        //     }
        // }




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
            print("test");
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