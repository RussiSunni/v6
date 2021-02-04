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

    List<string> currentWords = new List<string>();

    string word;
    char[] board;

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



        word = "COG";

        Words.Add("CAT");
        Words.Add("DOG");

        // Search(board, word);
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
        char[] board = new char[8];

        for (int i = 0; i < 8; i++)
        {
            if (Row1[i].childCount > 0)
            {

                board[i] = Row1[i].GetChild(0).gameObject.name[0];

                // print(board[i]);
            }
        }

        Search(board, Words);

        print(currentWords[0]);
        print(currentWords[1]);
        // int words = 0;
        // for (int h = 0; h < 3; h++)
        // {

        //     // got to move to the loop with all 3 rows


        //     int firstLetterOfWordPosition;

        //     Words.Clear();
        //     for (int i = 0; i < Rows[h].Count; i++)
        //     {

        //         if (Rows[h][i].childCount > 0 && Rows[h][i + 1].childCount > 0)
        //             if (Rows[h][i - 1].childCount == 0)
        //             {
        //                 for (int j = 0; j < 8; j++)
        //                 {
        //                     if (Rows[h][i + j].childCount == 0)
        //                     {
        //                         int wordLength = j - i;
        //                         //  print(j);
        //                     }
        //                 }
        //             }





        //         // check how many words there are
        //         // loop each word separately !!
        //         if (Rows[h][i].childCount > 0 && Rows[h][i + 1].childCount > 0 && Rows[h][i + 2].childCount > 0)
        //         {
        //             // number of words
        //             words++;
        //             firstLetterOfWordPosition = i;

        //             for (int k = 0; k < words; k++)
        //             {

        //                 if (Rows[h][firstLetterOfWordPosition].GetChild(0).gameObject.name == "C")
        //                 {
        //                     if (Rows[h][firstLetterOfWordPosition + 1].GetChild(0).gameObject.name == "A")
        //                     {

        //                         // CAT ---------------------
        //                         if (Rows[h][firstLetterOfWordPosition + 2].GetChild(0).gameObject.name == "T")
        //                         {
        //                             if (!WordSprites.Contains(catSprite))
        //                             {
        //                                 WordSprites.Add(catSprite);
        //                             }
        //                         }

        //                     }

        //                 }


        //                 // DOG ---------------------
        //                 if (Rows[h][firstLetterOfWordPosition].GetChild(0).gameObject.name == "D")
        //                 {
        //                     if (Rows[h][firstLetterOfWordPosition + 1].GetChild(0).gameObject.name == "O")
        //                     {
        //                         if (Rows[h][firstLetterOfWordPosition + 2].GetChild(0).gameObject.name == "G")
        //                         {
        //                             if (!WordSprites.Contains(dogSprite))
        //                             {
        //                                 WordSprites.Add(dogSprite);
        //                             }
        //                         }

        //                     }

        //                 }


        //                 // FROG ---------------------

        //             }
        //         }
        //         if (words == 0)
        //             WordSprites.Clear();











        //         // checking if first letters have been removed
        //         if (Rows[h][i].childCount > 0)
        //         {
        //             Words.Add(Rows[h][i].GetChild(0).gameObject.name);
        //         }
        //     }
        // }



        // //RULES ----------------       

        // if (WordSprites.Count > 1)
        // {
        //     ClearImage(centerWordImage);
        //     AddImage(leftWordImage, WordSprites[0]);
        //     AddImage(rightWordImage, WordSprites[1]);
        //     // ClearImage(backgroundWordImage);
        // }
        // else if (WordSprites.Count == 1)
        // {
        //     ClearImage(leftWordImage);
        //     ClearImage(rightWordImage);
        //     AddImage(centerWordImage, WordSprites[0]);
        //     // ClearImage(backgroundWordImage);
        // }
        // else
        // {
        //     ClearImage(centerWordImage);
        //     ClearImage(leftWordImage);
        //     ClearImage(rightWordImage);
        //     // ClearImage(backgroundWordImage);
        // }
    }



    private bool Search(char[] board, List<string> words)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int h = 0; h < 2; h++)
            {
                if (board[i] == words[h][0] && dfs(board, i, 0, words[h]))
                {
                    //print(words[h]);
                }
            }
        }

        return false;
    }

    public bool dfs(char[] board, int i, int count, string word)
    {
        //print(word);

        if (count == word.Length)
            return true;

        if (i < 0 || i >= board.Length || board[i] != word[count])
            return false;


        char temp = board[i];
        board[i] = ' ';

        bool found = dfs(board, i + 1, count + 1, word);

        board[i] = temp;

        if (found && !currentWords.Contains(word))
        {
            currentWords.Add(word);
        }


        return found;
    }

}