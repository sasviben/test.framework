Feature: Games Online Betting


  Scenario: the user should be able to play the Jocuri game (uid:d980f139-d083-4bc0-9f99-d87d8414cad2)
    
    Given the user is logged in
    And the user is on the page "Games"
    When the user plays "Sweet Bonanza" game
    Then the user's balance is changed
