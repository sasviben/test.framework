Feature: Games Online Betting


  Scenario: the online player should be able to play the Jocuri game (uid:d7ec5146-5c40-4ab0-90e0-671af579475f)
    Given the player is logged in
    And the player is on the page "GAMES"
    When the player plays "Sweet Bonanza" game
    Then the game is played
