using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CARD_DISPLAY : MonoBehaviour
{
    public CARD card;
    public Text PlayerNameText;
    public Text PositionText;

    public Image ArtWorkImage;

    public Text RatingTex;
    public Text ShootingTex;
    // Start is called before the first frame update
    void Start()
    {
        PlayerNameText.text = card.PlayerName;
        PositionText.text = card.Position;
        ArtWorkImage.sprite = card.ArtWork;
        RatingTex.text = card.Rating.ToString();
        ShootingTex.text = card.Shooting.ToString();
    }

    public void ChangePlayer(CARD newCard)
    {
        card = newCard;
        PlayerNameText.text = card.PlayerName;
        PositionText.text = card.Position;
        ArtWorkImage.sprite = card.ArtWork;
        RatingTex.text = card.Rating.ToString();
        ShootingTex.text = card.Shooting.ToString();
    }
}
