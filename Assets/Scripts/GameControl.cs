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
    List<Sprite> wordSprites = new List<Sprite>();

    List<string> Words = new List<string>();

    List<string> currentWords = new List<string>();

    string word;
    char[] board;

    public Image centerWordImage, leftWordImage, rightWordImage, backgroundWordImage;
    public Sprite catSprite, dogSprite, bearSprite, frogSprite, goatSprite, duckSprite, snakeSprite, mouseSprite, horseSprite, tigerSprite, zebraSprite, lizardSprite, donkeySprite, monkeySprite, wolfSprite, batSprite, camelSprite, chickenSprite, dolphinSprite, sharkSprite, forestSprite;
    public Sprite motherSprite, sisterSprite, familySprite;

    public Animator fairyAnimator;

    IDictionary<string, Sprite> wordImages = new Dictionary<string, Sprite>();

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


        //Words
        Words.Add("CAT");
        Words.Add("DOG");
        Words.Add("BEAR");


        //Dictionary Results
        wordImages.Add("CAT", catSprite);
        wordImages.Add("DOG", dogSprite);
        wordImages.Add("BEAR", bearSprite);


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
        print(wordImages["BEAR"]);

        // load current board

        // Row 1
        char[] board1 = new char[8];
        for (int i = 0; i < 8; i++)
        {
            if (Row1[i].childCount > 0)
            {
                board1[i] = Row1[i].GetChild(0).gameObject.name[0];
            }
        }

        // Row 2
        char[] board2 = new char[8];
        for (int i = 0; i < 8; i++)
        {
            if (Row2[i].childCount > 0)
            {
                board2[i] = Row2[i].GetChild(0).gameObject.name[0];
            }
        }

        // Row 3
        char[] board3 = new char[8];
        for (int i = 0; i < 8; i++)
        {
            if (Row3[i].childCount > 0)
            {
                board3[i] = Row3[i].GetChild(0).gameObject.name[0];
            }
        }



        // run the function
        Search(board1, Words);
        Search(board2, Words);
        Search(board3, Words);


        // for this string in Current Words, use this
        for (int i = 0; i < currentWords.Count; i++)
        {
            if (!wordSprites.Contains(wordImages[currentWords[i]]))
                wordSprites.Add(wordImages[currentWords[i]]);
        }



        // //RULES ----------------       

        if (currentWords.Count > 1)
        {
            ClearImage(centerWordImage);
            AddImage(leftWordImage, wordSprites[0]);
            AddImage(rightWordImage, wordSprites[1]);
            // ClearImage(backgroundWordImage);
        }
        else if (currentWords.Count == 1)
        {
            ClearImage(leftWordImage);
            ClearImage(rightWordImage);

            AddImage(centerWordImage, wordSprites[0]);
            // ClearImage(backgroundWordImage);
        }
        else
        {
            ClearImage(centerWordImage);
            ClearImage(leftWordImage);
            ClearImage(rightWordImage);
            // ClearImage(backgroundWordImage);
        }

        // clear for next update
        wordSprites.Clear();
        currentWords.Clear();
    }



    private bool Search(char[] board, List<string> words)
    {

        for (int i = 0; i < board.Length; i++)
        {
            for (int h = 0; h < words.Count; h++)
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
        //    print(word);

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