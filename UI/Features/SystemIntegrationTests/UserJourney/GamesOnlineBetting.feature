@GAMES
Feature: Games Online Betting


  Scenario: the online player should be able to play the Jocuri game (uid:a1be29b4-1ee5-47ed-9580-96c6cb1d70a4)
    Given the player is logged in
    And the player is on the page "GAMES"
    When the player plays "Sweet Bonanza" game
    Then the game is played
