using System;
namespace Nancy.Simple
{
    public class Game
    {
        // Id of the current tournament
        public string tournament_id;

        // Id of the current sit'n'go game. You can use this to link a
        // sequence of game states together for logging purposes, or to
        // make sure that the same strategy is played for an entire game
        public string game_id;

        // Index of the current round within a sit'n'go
        public int round;

        // Index of the betting opportunity within a round
        public int bet_index;

        // The small blind in the current round. The big blind is twice the
        // small blind
        public int small_blind;

        // The amount of the largest current bet from any one player
        public int current_buy_in;

        // The size of the pot (sum of the player bets)
        public int pot;

        // Minimum raise amount. To raise you have to return at least:
        // current_buy_in - players[in_action][bet] + minimum_raise
        public int minimum_raise;

        // The index of the player on the dealer button in this round
        // The first player is (dealer+1)%(players.length)
        public int dealer;

        // Number of orbits completed. (The number of times the dealer
        // button returned to the same player.)
        public int orbits;

        // The index of your player, in the players array
        public int in_action;

        // An array of the players. The order stays the same during the
        // entire tournament
        public Player[] players;

        // Finally the array of community cards.
        public Card[] community_cards;
    }

    public class Player
    {
        // Id of the player (same as the index)
        public int id;

        // Name specified in the tournament config
        public string name;

        // Status of the player:
        //   - active: the player can make bets, and win the current pot
        //   - folded: the player folded, and gave up interest in
        //       the current pot. They can return in the next round.
        //   - out: the player lost all chips, and is out of this sit'n'go
        public string status;

        // Version identifier returned by the player
        public string version;

        // Amount of chips still available for the player. (Not including
        // the chips the player bet in this round.)
        public int stack;

        // The amount of chips the player put into the pot
        public int bet;

        // The cards of the player. This is only visible for your own player
        // except after showdown, when cards revealed are also included.
        public Card[] hole_cards;
    }

    public class Card
    {
        // Suit of the card. Possible values are: clubs,spades,hearts,diamonds
        public string suit;

        // Rank of the card. Possible values are numbers 2-10 and J,Q,K,A
        public string rank;
    }
}
