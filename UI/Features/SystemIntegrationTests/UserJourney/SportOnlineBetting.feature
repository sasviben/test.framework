Feature: Sport Online Betting


  @RULES_automated @regression @acceptance
  Scenario: the online player should be able to purchase a Prematch simple ticket (uid:f2c6ffc7-1786-4a19-9e23-52cb52b13ec4)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    When the player purchases an "ONLINE" sport "SIMPLE" ticket
    Then the "ONLINE" sport "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the ticket stake
