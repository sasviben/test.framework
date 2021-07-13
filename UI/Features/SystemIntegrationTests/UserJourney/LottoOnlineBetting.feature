Feature: Lotto Online Betting


  @RULES_automated @regression @acceptance @smoke
  Scenario: the online player should be able to purchase a Lotto simple ticket (uid:7e0a4ea0-c1f2-4ef9-9c6d-5a8f66966cbf)
    Given the player is logged in
    And the player has added "1" Lotto selection to the Betslip
    When the player purchases an "ONLINE" Lotto "SIMPLE" ticket
    Then the "ONLINE" Lotto "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the ticket stake
