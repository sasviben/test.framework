@GAMES
Feature: Games Online Betting


  @RULES_automation_todo @regression @acceptance @smoke
  Scenario: the online player should be able to play the Jocuri game (uid:f5ca2fe3-92bf-4921-ae7b-8b098254d873)
    Given the player is logged in
    And the player is on the page "GAMES"
    When the player plays "Sweet Bonanza" game
    Then the game is played
