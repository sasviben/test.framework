Feature: Lotto Online Betting


  @RULES_automated @regression @acceptance @smoke
  Scenario: the online player should be able to purchase a Lotto simple ticket (uid:b0afcf6e-f620-49a3-9e30-5dddc7895f39)
    Given the player is logged in
    And the player has added "1" Lotto selection to the Betslip
    When the player purchases an "ONLINE" Lotto "SIMPLE" ticket
    Then the "ONLINE" Lotto "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the ticket stake
