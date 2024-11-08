using UnityEngine;

public class GameManager : MonoBehaviour
{
    // This method is called on the first frame
    void Start()
    {
        // Instantiate two Player objects
        Player player1 = new Player();
        Player player2 = new Player();

        // Initialize each player with name and health
        player1.InitializePlayer("PlayerOne", 50);
        player2.InitializePlayer("PlayerTwo", 60);

        // Demonstrate method overloading by healing each player
        player1.Heal(20); // Heal by a specific amount
        player2.Heal(true); // Fully restore health

        // Display the total player count
        Player.ShowPlayerCount();
    }
}
